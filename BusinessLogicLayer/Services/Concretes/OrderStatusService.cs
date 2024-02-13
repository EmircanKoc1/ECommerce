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
    public class OrderStatusService : IOrderStatusService
    {
        IMapper _mapper;
        IOrderStatusRepository _repository;

        public OrderStatusService(IMapper mapper, IOrderStatusRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        void CustomValidator(OrderStatusDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.Order is null && dto.OrderId is null or 0)
                dto.ThrowIfNull("", CustomException.ForeignKeyOrNavigationPropertyNullException);
        }

        public OrderStatusDto Add(OrderStatusDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<OrderStatus>(dto);

            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderStatusDto>(entity);

        }

        public async Task<OrderStatusDto> AddAsync(OrderStatusDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<OrderStatus>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<OrderStatusDto>(entity);
        }

        public IEnumerable<OrderStatusDto> AddRange(IEnumerable<OrderStatusDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<OrderStatus>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<OrderStatusDto>>(entities);

        }

        public async Task<IEnumerable<OrderStatusDto>> AddRangeAsync(IEnumerable<OrderStatusDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<OrderStatus>>(dtos);

            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<OrderStatusDto>>(entities);
        }

        public OrderStatusDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderStatusDto>(entity);
        }

        public OrderStatusDto Delete(OrderStatusDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderStatusDto>(entity);
        }

        public async Task<OrderStatusDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<OrderStatusDto>(entity);
        }

        public void DeleteRange(IEnumerable<OrderStatusDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<OrderStatus>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<OrderStatus, bool>> predicate)
        {
            predicate.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();


        }

        public IEnumerable<OrderStatusDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderStatusDto>>(entities);

        }

        public IEnumerable<OrderStatusDto> GetAll(PaginationModel paginationModel, Expression<Func<OrderStatus, bool>> predicate, Expression<Func<OrderStatus, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<OrderStatus, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderStatusDto>>(entities);

        }

        public async Task<IEnumerable<OrderStatusDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<OrderStatus, bool>> predicate, Expression<Func<OrderStatus, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<OrderStatus, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<OrderStatusDto>>(entities);
        }

        public OrderStatusDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderStatusDto>(entity);

        }

        public async Task<OrderStatusDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderStatusDto>(entity);
        }

        public OrderStatusDto GetFirstOrDefault(Expression<Func<OrderStatus, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderStatusDto>(entity);
        }

        public async Task<OrderStatusDto> GetFirstOrDefaultAsync(Expression<Func<OrderStatus, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<OrderStatusDto>(entity);
        }

        public (OrderStatusDto, OrderStatusDto) Update(OrderStatusDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<OrderStatusDto>(foundedEntity);
            var newEntity = _mapper.Map<OrderStatus>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);

        }
    }

}
