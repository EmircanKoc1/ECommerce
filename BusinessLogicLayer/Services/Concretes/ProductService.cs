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
    public class ProductService : IProductService
    {
        IMapper _mapper;
        IProductRepository _repository;

        public ProductService(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        void CustomProductValidator(ProductDto dto)
        {

            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.Category is null && dto.CategoryId is null or 0)
                dto.ThrowIfNull("", CustomException.ForeignKeyOrNavigationPropertyNullException);


            if (dto.SubCategory is null && dto.SubCategoryId is null or 0)
                dto.ThrowIfNull("", CustomException.ForeignKeyOrNavigationPropertyNullException);


            if (dto.Brand is null && dto.BrandId is null or 0)
                dto.ThrowIfNull("", CustomException.ForeignKeyOrNavigationPropertyNullException);
        }

        public ProductDto Add(ProductDto dto)
        {
            CustomProductValidator(dto);

            var entity = _mapper.Map<Product>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductDto>(entity);

        }

        public async Task<ProductDto> AddAsync(ProductDto dto)
        {
            CustomProductValidator(dto);

            var entity = _mapper.Map<Product>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<ProductDto>(entity);
        }

        public IEnumerable<ProductDto> AddRange(IEnumerable<ProductDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomProductValidator(dto);

            var entities = _mapper.Map<IEnumerable<Product>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();


            return _mapper.Map<IEnumerable<ProductDto>>(entities);

        }

        public async Task<IEnumerable<ProductDto>> AddRangeAsync(IEnumerable<ProductDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomProductValidator(dto);

            var entities = _mapper.Map<IEnumerable<Product>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();


            return _mapper.Map<IEnumerable<ProductDto>>(entities);
        }

        public ProductDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductDto>(entity);
        }

        public ProductDto Delete(ProductDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductDto>(entity);
        }

        public async Task<ProductDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ProductDto>(entity);
        }

        public void DeleteRange(IEnumerable<ProductDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Product>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();
        }

        public void DeleteRange(Expression<Func<Product, bool>> predicate)
        {
            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<ProductDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            return _mapper.Map<IEnumerable<ProductDto>>(entities);
        }

        public IEnumerable<ProductDto> GetAll(PaginationModel paginationModel, Expression<Func<Product, bool>> predicate, Expression<Func<Product, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Product, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<ProductDto>>(entities);
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Product, bool>> predicate, Expression<Func<Product, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Product, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<ProductDto>>(entities);
        }

        public ProductDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            return _mapper.Map<ProductDto>(entity);
        }

        public async Task<ProductDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductDto>(entity);
        }

        public ProductDto GetFirstOrDefault(Expression<Func<Product, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductDto>(entity);
        }

        public async Task<ProductDto> GetFirstOrDefaultAsync(Expression<Func<Product, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ProductDto>(entity);
        }

        public (ProductDto, ProductDto) Update(ProductDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var newEntity = _mapper.Map<Product>(dto);
            var oldEntity = _mapper.Map<ProductDto>(foundedEntity);
            _repository.Update(newEntity);

            return (oldEntity, dto);
        }
    }

}
