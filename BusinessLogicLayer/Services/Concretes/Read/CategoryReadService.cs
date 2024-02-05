using BusinessLogicLayer.Services.Abstracts.Read;
using CoreLayer.DataTransferObjects.Category;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes.Read
{
    public class CategoryReadService : ICategoryReadService
    {
        public IEnumerable<CategoryForReadDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryForReadDto> GetAll(bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CategoryForReadDto> GetAll(PaginationModel paginationModel, Expression<Func<Category, bool>> predicate, Expression<Func<Category, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Category, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryForReadDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Category, bool>> predicate, Expression<Func<Category, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Category, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public CategoryForReadDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryForReadDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryForReadDto> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<Category, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public CategoryForReadDto GetFirstOrDefault(Expression<Func<Category, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryForReadDto> GetFirstOrDefaultAsync(Expression<Func<Category, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }
    }

}
