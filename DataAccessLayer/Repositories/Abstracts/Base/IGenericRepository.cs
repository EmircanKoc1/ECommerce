using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Repositories.Abstracts.Base
{
    public interface IGenericRepository<T> : IWriteRepository<T>, IReadRepository<T>
    where T : BaseEntity
    {

    }
}
