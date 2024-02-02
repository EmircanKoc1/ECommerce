using CoreLayer.Exceptions;
using DataAccessLayer.Context;
using DataAccessLayer.Entities.Base.Concretes;
using DataAccessLayer.Repositories.Abstracts.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Concretes.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
    where T : BaseEntity
    {
        ECommerceDbContext _context;
        DbSet<T> _table => _context.Set<T>();
        public GenericRepository(ECommerceDbContext context)
            => _context = context ?? throw new DbContextNotRegisteredException(nameof(ECommerceDbContext));

        void x()=>_context.Set<T>();
       

    }
}
