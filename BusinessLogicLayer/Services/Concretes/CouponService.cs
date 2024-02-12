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
    public class CouponService : ICouponService
    {
        ICouponRepository _repository;
        IMapper _mapper;

        public CouponService(ICouponRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CouponDto Add(CouponDto dto)
        {
            Coupon entity = null;

            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.Id is not 0)
                entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityAlreadyExistsException);

            entity = _mapper.Map<Coupon>(dto);

            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<CouponDto>(entity);
        }

        public async Task<CouponDto> AddAsync(CouponDto dto)
        {
            Coupon entity = null;

            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.Id is not 0)
                entity = await _repository.GetByIdAsync(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityAlreadyExistsException);

            entity = _mapper.Map<Coupon>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<CouponDto>(entity);
        }

        public IEnumerable<CouponDto> AddRange(IEnumerable<CouponDto> dtos)
        {

            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Coupon>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<CouponDto>>(entities);

        }

        public async Task<IEnumerable<CouponDto>> AddRangeAsync(IEnumerable<CouponDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Coupon>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<CouponDto>>(entities);
        }

        public CouponDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);


            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CouponDto>(entity);
        }

        public CouponDto Delete(CouponDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CouponDto>(entity);
        }

        public async Task<CouponDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);


            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CouponDto>(entity);
        }

        public void DeleteRange(IEnumerable<CouponDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Coupon>>(dtos);
            _repository.DeleteRange(entities);
            _repository.SaveChanges();
        }

        public void DeleteRange(Expression<Func<Coupon, bool>> predicate)
        {
            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<CouponDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);
            return _mapper.Map<IEnumerable<CouponDto>>(entities);

        }

        public IEnumerable<CouponDto> GetAll(PaginationModel paginationModel, Expression<Func<Coupon, bool>> predicate, Expression<Func<Coupon, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Coupon, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<CouponDto>>(entities);

        }

        public async Task<IEnumerable<CouponDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Coupon, bool>> predicate, Expression<Func<Coupon, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Coupon, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<CouponDto>>(entities);
        }

        public CouponDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<CouponDto>(entity);
        }

        public async Task<CouponDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {

            var entity = await _repository.GetByIdAsync(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<CouponDto>(entity);
        }

        public CouponDto GetFirstOrDefault(Expression<Func<Coupon, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);
            return _mapper.Map<CouponDto>(entity);
        }

        public async Task<CouponDto> GetFirstOrDefaultAsync(Expression<Func<Coupon, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);
            return _mapper.Map<CouponDto>(entity);
        }

        public (CouponDto, CouponDto) Update(CouponDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<CouponDto>(foundedEntity);
            var newEntity = _mapper.Map<Coupon>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);
        }
    }

}
