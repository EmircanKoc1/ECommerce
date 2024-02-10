using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class ProductImageService : IProductImageService
    {
        public ProductImageDto Add(ProductImageDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ProductImageDto> AddAsync(ProductImageDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductImageDto> AddRange(IEnumerable<ProductImageDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductImageDto>> AddRangeAsync(IEnumerable<ProductImageDto> dtos)
        {
            throw new NotImplementedException();
        }

        public ProductImageDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public ProductImageDto Delete(ProductImageDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<ProductImageDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductImageDto> DeleteRange(IEnumerable<ProductImageDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductImageDto> DeleteRange(Expression<Func<ProductImage, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductImageDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductImageDto> GetAll(PaginationModel paginationModel, Expression<Func<ProductImage, bool>> predicate, Expression<Func<ProductImage, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ProductImage, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductImageDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<ProductImage, bool>> predicate, Expression<Func<ProductImage, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ProductImage, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public ProductImageDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<ProductImageDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public ProductImageDto GetFirstOrDefault(Expression<Func<ProductImage, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<ProductImageDto> GetFirstOrDefaultAsync(Expression<Func<ProductImage, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (ProductImageDto, ProductImageDto) Update(ProductImageDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
