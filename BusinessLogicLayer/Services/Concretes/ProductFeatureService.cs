using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class ProductFeatureService : IProductFeatureService
    {
        public ProductFeatureDto Add(ProductFeatureDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ProductFeatureDto> AddAsync(ProductFeatureDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductFeatureDto> AddRange(IEnumerable<ProductFeatureDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductFeatureDto>> AddRangeAsync(IEnumerable<ProductFeatureDto> dtos)
        {
            throw new NotImplementedException();
        }

        public ProductFeatureDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public ProductFeatureDto Delete(ProductFeatureDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<ProductFeatureDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductFeatureDto> DeleteRange(IEnumerable<ProductFeatureDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductFeatureDto> DeleteRange(Expression<Func<ProductFeature, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductFeatureDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductFeatureDto> GetAll(PaginationModel paginationModel, Expression<Func<ProductFeature, bool>> predicate, Expression<Func<ProductFeature, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ProductFeature, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductFeatureDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<ProductFeature, bool>> predicate, Expression<Func<ProductFeature, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ProductFeature, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public ProductFeatureDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<ProductFeatureDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public ProductFeatureDto GetFirstOrDefault(Expression<Func<ProductFeature, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<ProductFeatureDto> GetFirstOrDefaultAsync(Expression<Func<ProductFeature, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (ProductFeatureDto, ProductFeatureDto) Update(ProductFeatureDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
