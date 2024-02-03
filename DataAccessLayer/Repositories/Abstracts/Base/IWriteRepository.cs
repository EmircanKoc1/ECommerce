using DataAccessLayer.Entities.Base.Concretes;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Abstracts.Base
{
    public interface IWriteRepository<T>
    where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        bool Add(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void AddRange(IEnumerable<T> entities);

        
        
        bool Delete(T entity);
        Task<bool> DeleteAsync(T entity);
        bool DeleteAsync(long id);
        Task<bool> DeleteAsync(long id);
        bool DeleteRange(IEnumerable<T> entities);
        bool DeleteRange(Expression<Func<T, bool>> predicate);



        Task<bool> DeleteRangeAsync(IEnumerable<T> entities);
        Task<bool> DeleteRangeAsync(Expression<Func<T,bool>> predicate);

        bool Update(T entity);



        int SaveChanges();
        Task<int> SaveChangesAsync();



    }
}
