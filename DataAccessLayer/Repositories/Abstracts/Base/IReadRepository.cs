using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities.Base;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Abstracts.Base
{
    public interface IReadRepository<T>
    where T : BaseEntity
    {
        Task<T> GetByIdAsync(bool tracking = false, params object[] keyValues);
        T GetById(bool tracking = false, params object[] keyValues);
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate, bool tracking = false);
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate, bool tracking = false);
        IEnumerable<T> GetAll(PaginationModel paginationModel, bool tracking = false);
        IQueryable<T> GetAll(bool tracking = false);

        IEnumerable<T> GetAll(
            PaginationModel paginationModel,
            Expression<Func<T, bool>> predicate,
            Expression<Func<T, long>> orderByKeySelector,
            OrderByDirection direction,
            bool tracking = false,
            params Expression<Func<T, long>>[] thenByKeySelector);

        Task<IEnumerable<T>> GetAllAsync(
           PaginationModel paginationModel,
           Expression<Func<T, bool>> predicate,
           Expression<Func<T, long>> orderByKeySelector,
           OrderByDirection direction,
           bool tracking = false,
           params Expression<Func<T, long>>[] thenByKeySelector);

        Task<T> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<T, object>>[] includes);







    }
}
