using DataAccessLayer.Context;
using DataAccessLayer.Entities.Base.Concretes;
using DataAccessLayer.Repositories.Abstracts.Base;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Concretes.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
    where T : BaseEntity
    {
        ECommerceDbContext _context;
        DbSet<T> _table;
        public GenericRepository(ECommerceDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        void f()
        {
            _context.
        }



    }
}
