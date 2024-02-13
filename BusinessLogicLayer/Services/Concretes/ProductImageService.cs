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
    public class ProductImageService : IProductImageService
    {
        IMapper _mapper;
        IProductImageRepository _repository;

        public ProductImageService(IMapper mapper, IProductImageRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        void CustomValidator(ProductImageDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.ProductId is null or 0)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

        }

        public ProductImageDto Add(ProductImageDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<ProductImage>(dto);

            _repository.Add(entity);
            _repository.SaveChanges();


            return _mapper.Map<ProductImageDto>(entity);

        }

        public async Task<ProductImageDto> AddAsync(ProductImageDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<ProductImage>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();


            return _mapper.Map<ProductImageDto>(entity);

        }

        public IEnumerable<ProductImageDto> AddRange(IEnumerable<ProductImageDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<ProductImage>>(dtos);

            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<ProductImageDto>>(entities);
        }

        public async Task<IEnumerable<ProductImageDto>> AddRangeAsync(IEnumerable<ProductImageDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<ProductImage>>(dtos);

            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<ProductImageDto>>(entities);
        }

        public ProductImageDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductImageDto>(entity);
        }

        public ProductImageDto Delete(ProductImageDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductImageDto>(entity);


        }

        public async Task<ProductImageDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductImageDto>(entity);
        }

        public void DeleteRange(IEnumerable<ProductImageDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<ProductImage>>(dtos);
            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<ProductImage, bool>> predicate)
        {
            predicate.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();

        }

        public IEnumerable<ProductImageDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ProductImageDto>>(entities);
        }

        public IEnumerable<ProductImageDto> GetAll(PaginationModel paginationModel, Expression<Func<ProductImage, bool>> predicate, Expression<Func<ProductImage, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ProductImage, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ProductImageDto>>(entities);
        }

        public async Task<IEnumerable<ProductImageDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<ProductImage, bool>> predicate, Expression<Func<ProductImage, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ProductImage, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ProductImageDto>>(entities);
        }

        public ProductImageDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductImageDto>(entity);
        }

        public async Task<ProductImageDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductImageDto>(entity);
        }

        public ProductImageDto GetFirstOrDefault(Expression<Func<ProductImage, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductImageDto>(entity);
        }

        public async Task<ProductImageDto> GetFirstOrDefaultAsync(Expression<Func<ProductImage, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductImageDto>(entity);
        }

        public (ProductImageDto, ProductImageDto) Update(ProductImageDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<ProductImageDto>(foundedEntity);
            var newEntity = _mapper.Map<ProductImage>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);
        }
    }

}
