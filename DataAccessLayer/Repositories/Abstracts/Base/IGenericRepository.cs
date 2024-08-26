using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Repositories.Abstracts.Base
{
    public interface IGenericRepository<T> : IWriteRepository<T>, IReadRepository<T>
    where T : BaseEntity
    {

    }
}
