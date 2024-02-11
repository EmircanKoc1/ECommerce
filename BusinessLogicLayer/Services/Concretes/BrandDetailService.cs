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
    public class BrandDetailService : IBrandDetailService
    {
        IBrandDetailRepository _repository;
        IMapper _mapper;

        public BrandDetailService(IBrandDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public BrandDetailDto Add(BrandDetailDto dto)
        {

            if (dto.Brand is null && dto.BrandId is 0)
                throw new ForeignKeyOrNavigationPropertyNullException(nameof(Brand));

            var entity = _repository.GetById(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(entity));

            entity = _mapper.Map<BrandDetail>(dto);

            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<BrandDetailDto>(entity);

        }

        public async Task<BrandDetailDto> AddAsync(BrandDetailDto dto)
        {
            if (dto.Brand is null && dto.BrandId is 0)
                throw new ForeignKeyOrNavigationPropertyNullException(nameof(Brand));

            var entity = await _repository.GetByIdAsync(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(entity));

            entity = _mapper.Map<BrandDetail>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<BrandDetailDto>(entity);
        }

        public IEnumerable<BrandDetailDto> AddRange(IEnumerable<BrandDetailDto> dtos)
        {
            if (dtos is null)
                dtos.ThrowIfNull(nameof(BrandDetail), CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull(nameof(BrandDetail), CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<BrandDetail>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<BrandDetailDto>>(entities);

        }

        public async Task<IEnumerable<BrandDetailDto>> AddRangeAsync(IEnumerable<BrandDetailDto> dtos)
        {
            if (dtos is null)
                dtos.ThrowIfNull(nameof(BrandDetail), CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull(nameof(BrandDetail), CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<BrandDetail>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<BrandDetailDto>>(entities);
        }

        public BrandDetailDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull(nameof(BrandDetail), CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<BrandDetailDto>(entity);
        }

        public BrandDetailDto Delete(BrandDetailDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull(nameof(BrandDetail), CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<BrandDetailDto>(entity);
        }

        public async Task<BrandDetailDto> DeleteAsync(long id)
        {

            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull(nameof(BrandDetail), CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<BrandDetailDto>(entity);
        }

        public void DeleteRange(IEnumerable<BrandDetailDto> dtos)
        {
            dtos.ThrowIfNull(nameof(BrandDetail), CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull(nameof(BrandDetail), CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<BrandDetail>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<BrandDetail, bool>> predicate)
        {
            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<BrandDetailDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            return _mapper.Map<IEnumerable<BrandDetailDto>>(entities);
        }

        public IEnumerable<BrandDetailDto> GetAll(PaginationModel paginationModel, Expression<Func<BrandDetail, bool>> predicate, Expression<Func<BrandDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<BrandDetail, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<BrandDetailDto>>(entities);
        }

        public async Task<IEnumerable<BrandDetailDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<BrandDetail, bool>> predicate, Expression<Func<BrandDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<BrandDetail, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<BrandDetailDto>>(entities);
        }

        public BrandDetailDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);
            entity.ThrowIfNull(nameof(BrandDetail), CustomException.EntityNotFoundException);

            return _mapper.Map<BrandDetailDto>(entity);
        }

        public async Task<BrandDetailDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);
            entity.ThrowIfNull(nameof(BrandDetail), CustomException.EntityNotFoundException);

            return _mapper.Map<BrandDetailDto>(entity);
        }

        public BrandDetailDto GetFirstOrDefault(Expression<Func<BrandDetail, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, false);
            entity.ThrowIfNull(nameof(BrandDetail), CustomException.EntityNotFoundException);

            return _mapper.Map<BrandDetailDto>(entity);
        }

        public async Task<BrandDetailDto> GetFirstOrDefaultAsync(Expression<Func<BrandDetail, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, false);
            entity.ThrowIfNull(nameof(BrandDetail), CustomException.EntityNotFoundException);

            return _mapper.Map<BrandDetailDto>(entity);
        }

        public (BrandDetailDto, BrandDetailDto) Update(BrandDetailDto dto)
        {
            dto.ThrowIfNull(nameof(BrandDetail), CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull(nameof(BrandDetail), CustomException.EntityNotFoundException);

            var newEntity = _mapper.Map<BrandDetail>(dto);
            _repository.Update(newEntity);
            _repository.SaveChanges();

            var oldEntity = _mapper.Map<BrandDetailDto>(foundedEntity);

            return (oldEntity, dto);


        }
    }

}
