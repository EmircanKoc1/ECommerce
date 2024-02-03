using DataAccessLayer.Entities.Base.Concretes;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Abstracts.Base
{
    public interface IWriteRepository<T>
    where T : BaseEntity
    {
        bool Add(T entity);
        Task<bool> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void AddRange(IEnumerable<T> entities);

        
        bool Delete(long id);
        void DeleteRange(IEnumerable<T> entities);
        bool Delete(T entity);
        void DeleteRange(Expression<Func<T,bool>> predicate);
   

        bool Update(T entity);



        int SaveChanges();
        Task<int> SaveChangesAsync();



    }
}
