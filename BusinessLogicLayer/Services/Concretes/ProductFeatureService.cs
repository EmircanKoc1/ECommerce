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
    public class ProductFeatureService : IProductFeatureService
    {
        IProductFeatureRepository _repository;
        IMapper _mapper;

        public ProductFeatureService(IProductFeatureRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        void CustomValidator(ProductFeatureDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.ProductId is null or 0)
                dto.ThrowIfNull("", CustomException.ForeignKeyOrNavigationPropertyNullException);
        }
        public ProductFeatureDto Add(ProductFeatureDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<ProductFeature>(dto);

            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductFeatureDto>(entity);
        }

        public async Task<ProductFeatureDto> AddAsync(ProductFeatureDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<ProductFeature>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<ProductFeatureDto>(entity);
        }

        public IEnumerable<ProductFeatureDto> AddRange(IEnumerable<ProductFeatureDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<ProductFeature>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();


            return _mapper.Map<IEnumerable<ProductFeatureDto>>(entities);
        }

        public async Task<IEnumerable<ProductFeatureDto>> AddRangeAsync(IEnumerable<ProductFeatureDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<ProductFeature>>(dtos);

            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<ProductFeatureDto>>(entities);

        }

        public ProductFeatureDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductFeatureDto>(entity);

        }

        public ProductFeatureDto Delete(ProductFeatureDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductFeatureDto>(entity);
        }

        public async Task<ProductFeatureDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductFeatureDto>(entity);
        }

        public void DeleteRange(IEnumerable<ProductFeatureDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<ProductFeature>>(dtos);
            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<ProductFeature, bool>> predicate)
        {
            predicate.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();

        }

        public IEnumerable<ProductFeatureDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);
            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ProductFeatureDto>>(entities);
        }

        public IEnumerable<ProductFeatureDto> GetAll(PaginationModel paginationModel, Expression<Func<ProductFeature, bool>> predicate, Expression<Func<ProductFeature, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ProductFeature, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);
            return _mapper.Map<IEnumerable<ProductFeatureDto>>(entities);


        }

        public async Task<IEnumerable<ProductFeatureDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<ProductFeature, bool>> predicate, Expression<Func<ProductFeature, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ProductFeature, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ProductFeatureDto>>(entities);

        }

        public ProductFeatureDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductFeatureDto>(entity);

        }

        public async Task<ProductFeatureDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductFeatureDto>(entity);
        }

        public ProductFeatureDto GetFirstOrDefault(Expression<Func<ProductFeature, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductFeatureDto>(entity);

        }

        public async Task<ProductFeatureDto> GetFirstOrDefaultAsync(Expression<Func<ProductFeature, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductFeatureDto>(entity);
        }

        public (ProductFeatureDto, ProductFeatureDto) Update(ProductFeatureDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<ProductFeatureDto>(foundedEntity);
            var newEntity = _mapper.Map<ProductFeature>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);


        }
    }

}
