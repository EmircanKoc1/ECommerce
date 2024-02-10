using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        public CategoryDto Add(CategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> AddAsync(CategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> AddRange(IEnumerable<CategoryDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> AddRangeAsync(IEnumerable<CategoryDto> dtos)
        {
            throw new NotImplementedException();
        }

        public CategoryDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public CategoryDto Delete(CategoryDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> DeleteRange(IEnumerable<CategoryDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> DeleteRange(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> GetAll(PaginationModel paginationModel, Expression<Func<Category, bool>> predicate, Expression<Func<Category, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Category, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Category, bool>> predicate, Expression<Func<Category, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Category, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public CategoryDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public CategoryDto GetFirstOrDefault(Expression<Func<Category, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetFirstOrDefaultAsync(Expression<Func<Category, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (CategoryDto, CategoryDto) Update(CategoryDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
