using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class ProductService : IProductService
    {
        public ProductDto Add(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> AddAsync(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> AddRange(IEnumerable<ProductDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> AddRangeAsync(IEnumerable<ProductDto> dtos)
        {
            throw new NotImplementedException();
        }

        public ProductDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public ProductDto Delete(ProductDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> DeleteRange(IEnumerable<ProductDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> DeleteRange(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> GetAll(PaginationModel paginationModel, Expression<Func<Product, bool>> predicate, Expression<Func<Product, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Product, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Product, bool>> predicate, Expression<Func<Product, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Product, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public ProductDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public ProductDto GetFirstOrDefault(Expression<Func<Product, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetFirstOrDefaultAsync(Expression<Func<Product, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (ProductDto, ProductDto) Update(ProductDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
