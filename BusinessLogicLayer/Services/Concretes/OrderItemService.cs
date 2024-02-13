using AutoMapper;
using BusinessLogicLayer.Extensions;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class OrderItemService : IOrderItemService
    {
        IOrderItemRepository _repository;
        IMapper _mapper;

        public OrderItemService(IOrderItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        void CustomValidator(OrderItemDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.Product is null && dto.ProductId is null or 0)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.Order is null && dto.OrderId is null or 0)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

        }


        public OrderItemDto Add(OrderItemDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<OrderItem>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderItemDto>(entity);

        }

        public async Task<OrderItemDto> AddAsync(OrderItemDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<OrderItem>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<OrderItemDto>(entity);
        }

        public IEnumerable<OrderItemDto> AddRange(IEnumerable<OrderItemDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<OrderItem>>(dtos);

            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<OrderItemDto>>(entities);

        }

        public async Task<IEnumerable<OrderItemDto>> AddRangeAsync(IEnumerable<OrderItemDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<OrderItem>>(dtos);

            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<OrderItemDto>>(entities);
        }

        public OrderItemDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderItemDto>(entity);

        }

        public OrderItemDto Delete(OrderItemDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderItemDto>(entity);
        }

        public async Task<OrderItemDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderItemDto>(entity);
        }

        public void DeleteRange(IEnumerable<OrderItemDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<OrderItem>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<OrderItem, bool>> predicate)
        {
            predicate.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<OrderItemDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderItemDto>>(entities);

        }

        public IEnumerable<OrderItemDto> GetAll(PaginationModel paginationModel, Expression<Func<OrderItem, bool>> predicate, Expression<Func<OrderItem, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<OrderItem, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderItemDto>>(entities);
        }

        public async Task<IEnumerable<OrderItemDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<OrderItem, bool>> predicate, Expression<Func<OrderItem, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<OrderItem, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderItemDto>>(entities);
        }

        public OrderItemDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderItemDto>(entity);

        }

        public async Task<OrderItemDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderItemDto>(entity);
        }

        public OrderItemDto GetFirstOrDefault(Expression<Func<OrderItem, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderItemDto>(entity);

        }

        public async Task<OrderItemDto> GetFirstOrDefaultAsync(Expression<Func<OrderItem, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderItemDto>(entity);
        }

        public (OrderItemDto, OrderItemDto) Update(OrderItemDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<OrderItemDto>(foundedEntity);
            var newEntity = _mapper.Map<OrderItem>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);

        }
    }

}
