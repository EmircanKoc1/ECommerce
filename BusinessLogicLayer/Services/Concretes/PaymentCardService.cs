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
    public class PaymentCardService : IPaymentCardService
    {
        IMapper _mapper;
        IPaymentCardRepository _repository;

        public PaymentCardService(IMapper mapper, IPaymentCardRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public PaymentCardDto Add(PaymentCardDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.User is null && dto.UserId is null or 0)
                throw new ForeignKeyOrNavigationPropertyNullException("");

            var entity = _repository.GetById(false, dto.Id);
            entity.ThrowIfNull("", CustomException.EntityAlreadyExistsException);

            entity = _mapper.Map<PaymentCard>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public async Task<PaymentCardDto> AddAsync(PaymentCardDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.User is null && dto.UserId is null or 0)
                throw new ForeignKeyOrNavigationPropertyNullException("");

            var entity = await _repository.GetByIdAsync(false, dto.Id);
            entity.ThrowIfNull("", CustomException.EntityAlreadyExistsException);

            entity = _mapper.Map<PaymentCard>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public IEnumerable<PaymentCardDto> AddRange(IEnumerable<PaymentCardDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
            {
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);
                if (dto.User is null && dto.UserId is null or 0)
                    throw new ForeignKeyOrNavigationPropertyNullException("");
            }

            var entities = _mapper.Map<IEnumerable<PaymentCard>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<PaymentCardDto>>(entities);

        }

        public async Task<IEnumerable<PaymentCardDto>> AddRangeAsync(IEnumerable<PaymentCardDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
            {
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);
                if (dto.User is null && dto.UserId is null or 0)
                    throw new ForeignKeyOrNavigationPropertyNullException("");
            }

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<PaymentCard>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<PaymentCardDto>>(entities);
        }

        public PaymentCardDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public PaymentCardDto Delete(PaymentCardDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public async Task<PaymentCardDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public void DeleteRange(IEnumerable<PaymentCardDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<PaymentCard>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<PaymentCard, bool>> predicate)
        {
            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<PaymentCardDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            return _mapper.Map<IEnumerable<PaymentCardDto>>(entities);
        }

        public IEnumerable<PaymentCardDto> GetAll(PaginationModel paginationModel, Expression<Func<PaymentCard, bool>> predicate, Expression<Func<PaymentCard, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<PaymentCard, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);


            return _mapper.Map<IEnumerable<PaymentCardDto>>(entities);
        }

        public async Task<IEnumerable<PaymentCardDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<PaymentCard, bool>> predicate, Expression<Func<PaymentCard, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<PaymentCard, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);


            return _mapper.Map<IEnumerable<PaymentCardDto>>(entities);

        }

        public PaymentCardDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public async Task<PaymentCardDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public PaymentCardDto GetFirstOrDefault(Expression<Func<PaymentCard, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public async Task<PaymentCardDto> GetFirstOrDefaultAsync(Expression<Func<PaymentCard, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<PaymentCardDto>(entity);
        }

        public (PaymentCardDto, PaymentCardDto) Update(PaymentCardDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);
            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<PaymentCardDto>(foundedEntity);
            var newEntity = _mapper.Map<PaymentCard>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);
        }
    }
}
