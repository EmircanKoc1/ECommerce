using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Repositories.Abstracts.Base
{
    public interface IWriteRepository<T>
    where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        bool Add(T entity);

        Task<bool> AddRangeAsync(IEnumerable<T> entities);
        bool AddRange(IEnumerable<T> entities);

        bool Delete(T entity);
        bool Delete(long id);
        bool DeleteRange(IEnumerable<T> entities);

        bool Update(T entity);

        int SaveChanges();
        Task<int> SaveChangesAsync();



    }
}
