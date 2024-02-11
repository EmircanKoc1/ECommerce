using AutoMapper;
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
    public class BrandService : IBrandService
    {
        IMapper _mapper;
        IBrandRepository _repository;

        public BrandService(IMapper mapper, IBrandRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public BrandDto Add(BrandDto dto)
        {
            //var entity = default(Brand);
            Brand entity = null;

            if (dto is null)
                throw new ParameterValueNullException(nameof(Brand));

            if (dto.Id is not 0)
                entity = _repository.GetById(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(Brand));

            entity = _mapper.Map<Brand>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<BrandDto>(entity);

        }

        public async Task<BrandDto> AddAsync(BrandDto dto)
        {
            Brand entity = null;

            if (dto.Id is not 0)
                entity = await _repository.GetByIdAsync(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(Brand));

            entity = _mapper.Map<Brand>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<BrandDto>(entity);

        }

        public IEnumerable<BrandDto> AddRange(IEnumerable<BrandDto> dtos)
        {

            if (dtos == null)
                throw new ParameterValueNullException(nameof(BrandDto));

            var entities = _mapper.Map<IEnumerable<Brand>>(dtos);

            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<BrandDto>>(entities);
        }

        public async Task<IEnumerable<BrandDto>> AddRangeAsync(IEnumerable<BrandDto> dtos)
        {
            if (dtos == null)
                throw new ParameterValueNullException(nameof(BrandDto));

            var entities = _mapper.Map<IEnumerable<Brand>>(dtos);

            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<BrandDto>>(entities);

        }

        public BrandDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Brand));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<BrandDto>(entity);
        }

        public BrandDto Delete(BrandDto dto)
        {

            if (dto is null)
                throw new ParameterValueNullException(nameof(Brand));

            var entity = _repository.GetById(false, dto.Id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Brand));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<BrandDto>(entity);
        }

        public async Task<BrandDto> DeleteAsync(long id)
        {


            var entity = await _repository.GetByIdAsync(false, id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Brand));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<BrandDto>(entity);
        }

        public IEnumerable<BrandDto> DeleteRange(IEnumerable<BrandDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(Brand));

            var entities = _mapper.Map<IEnumerable<Brand>>(dtos);
            _repository.DeleteRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<BrandDto>>(entities);

        }

        public IEnumerable<BrandDto> DeleteRange(Expression<Func<Brand, bool>> predicate)
        {
            var entities = _repository.GetAll().Where(predicate);

            if (entities is null)
                throw new EntityNotFoundException("");

            foreach (var entity in entities)
                _repository.Delete(entity);


            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<BrandDto>>(entities);
        }

        public IEnumerable<BrandDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entites = _repository.GetAll(paginationModel, tracking);
            return _mapper.Map<IEnumerable<BrandDto>>(entites);

        }

        public IEnumerable<BrandDto> GetAll(PaginationModel paginationModel, Expression<Func<Brand, bool>> predicate, Expression<Func<Brand, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Brand, long>>[] thenByKeySelector)
        {
            var entities = GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<BrandDto>>(entities);

        }

        public async Task<IEnumerable<BrandDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Brand, bool>> predicate, Expression<Func<Brand, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Brand, long>>[] thenByKeySelector)
        {
            var entities = await GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<BrandDto>>(entities);
        }

        public BrandDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            if (entity is null)
                throw new EntityNotFoundException(nameof(entity));

            return _mapper.Map<BrandDto>(entity);

        }

        public async Task<BrandDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetByIdAsync(tracking, keyValues);

            if (entity is null)
                throw new EntityNotFoundException(nameof(entity));

            return _mapper.Map<BrandDto>(entity);
        }

        public BrandDto GetFirstOrDefault(Expression<Func<Brand, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            if (entity is null)
                throw new EntityNotFoundException(nameof(entity));

            return _mapper.Map<BrandDto>(entity);

        }

        public async Task<BrandDto> GetFirstOrDefaultAsync(Expression<Func<Brand, bool>> predicate, bool tracking = false)
        {

            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            return _mapper.Map<BrandDto>(entity);
        }

        public (BrandDto, BrandDto) Update(BrandDto dto)
        {
            if (dto is null)
                throw new ParameterValueNullException(nameof(Brand));

            var foundedEntity = _repository.GetById(false, dto.Id);

            if (foundedEntity is null)
                throw new EntityNotFoundException(nameof(Brand));

            var oldEntity = _mapper.Map<BrandDto>(foundedEntity);

            var entity = _mapper.Map<Brand>(dto);

            _repository.Update(entity);
            _repository.SaveChanges();

          //  var newEntity = _mapper.Map<BrandDto>(entity);


            return (oldEntity, dto);

        }
    }

}
