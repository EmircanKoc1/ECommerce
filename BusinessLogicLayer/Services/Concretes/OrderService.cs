using AutoMapper;
using BusinessLogicLayer.Extensions;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Exceptions;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class OrderService : IOrderService
    {
        ICouponService _couponService;
        IOrderRepository _repository;
        IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper, ICouponService couponService)
        {
            _repository = repository;
            _mapper = mapper;
            _couponService = couponService;
        }

        public void OrderDtoValidator(OrderDto dto)
        {
            Order entity = null;

            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.Id is not 0)
                entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityAlreadyExistsException);

            if (dto.Address is null && dto.AddressId is null or 0)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.User is null && dto.UserId is null or 0)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.ShipmentCompany is null && dto.ShipmentCompanyId is null or 0)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (!dto.OrderItems.Any())
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);
        }
        public void ProcessOrderDiscount(OrderDto dto)
        {
            var now = DateTime.Now;
            if (dto.Coupon.ExpirationDate >= now)
            {
                if (dto.Coupon.MinimumPrice <= dto.TotalAmount)
                {
                    dto.DiscountAmount = dto.Coupon.DiscountAmount;
                    dto.FinalAmount = dto.TotalAmount - dto.DiscountAmount;
                    dto.OrderDate = now;
                    dto.OrderStatus ??= new OrderStatusDto
                    {
                        IsPreparing = true,
                    };
                }
                else
                    throw new CouponMinimumAmountNotReachedException("");
            }
            else
                throw new CouponExpireDateFinishedException("");
        }
        public OrderDto Add(OrderDto dto)
        {
            Order entity = null;

            OrderDtoValidator(dto);

            if (dto.Coupon is not null)
            {
                ProcessOrderDiscount(dto);
            }
            else if (dto.CouponId is not null or 0)
            {
                var coupon = _couponService.GetById(false, dto.CouponId);

                coupon.ThrowIfNull("Coupon", CustomException.EntityNotFoundException);

                ProcessOrderDiscount(dto);

            }
            entity = _mapper.Map<Order>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderDto>(entity);


        }

        public async Task<OrderDto> AddAsync(OrderDto dto)
        {
            Order entity = null;

            OrderDtoValidator(dto);

            if (dto.Coupon is not null)
            {
                ProcessOrderDiscount(dto);
            }
            else if (dto.CouponId is not null or 0)
            {
                var coupon = await _couponService.GetByIdAsync(false, dto.CouponId);

                coupon.ThrowIfNull("Coupon", CustomException.EntityNotFoundException);

                ProcessOrderDiscount(dto);

            }
            entity = _mapper.Map<Order>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<OrderDto>(entity);
        }

        public IEnumerable<OrderDto> AddRange(IEnumerable<OrderDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                OrderDtoValidator(dto);

            var entities = _mapper.Map<IEnumerable<Order>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<OrderDto>>(entities);

        }

        public async Task<IEnumerable<OrderDto>> AddRangeAsync(IEnumerable<OrderDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                OrderDtoValidator(dto);

            var entities = _mapper.Map<IEnumerable<Order>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<OrderDto>>(entities);
        }

        public OrderDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderDto>(entity);
        }

        public OrderDto Delete(OrderDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderDto>(entity);
        }

        public async Task<OrderDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderDto>(entity);
        }

        public void DeleteRange(IEnumerable<OrderDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Order>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<Order, bool>> predicate)
        {
            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<OrderDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderDto>>(entities);
        }

        public IEnumerable<OrderDto> GetAll(PaginationModel paginationModel, Expression<Func<Order, bool>> predicate, Expression<Func<Order, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Order, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderDto>>(entities);
        }

        public async Task<IEnumerable<OrderDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Order, bool>> predicate, Expression<Func<Order, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Order, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderDto>>(entities);

        }

        public OrderDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderDto>(entity);

        }

        public async Task<OrderDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderDto>(entity);

        }

        public OrderDto GetFirstOrDefault(Expression<Func<Order, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderDto>(entity);
        }

        public async Task<OrderDto> GetFirstOrDefaultAsync(Expression<Func<Order, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderDto>(entity);

        }

        public (OrderDto, OrderDto) Update(OrderDto dto)
        {
            OrderDtoValidator(dto);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var newEntity = _mapper.Map<Order>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            var oldEntity = _mapper.Map<OrderDto>(foundedEntity);

            return (oldEntity, dto);

        }
    }
}
