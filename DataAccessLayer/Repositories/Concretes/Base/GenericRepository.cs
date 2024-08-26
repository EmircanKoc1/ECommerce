using CoreLayer.Enums;
using CoreLayer.Exceptions;
using CoreLayer.Model;
using DataAccessLayer.Context;
using DataAccessLayer.Entities.Base;
using DataAccessLayer.Repositories.Abstracts.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Concretes.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
    where T : BaseEntity
    {
        protected ECommerceDbContext _context;
        protected DbSet<T> _table => _context.Set<T>();
        public GenericRepository(ECommerceDbContext context)
            => _context = context ?? throw new DbContextNotRegisteredException(nameof(ECommerceDbContext));
        //todo Add methods
        public bool Add(T entity)
        {
            var entry = _table.Add(entity);
            return entry.State == EntityState.Added;
        }
        public async Task<bool> AddAsync(T entity)
        {
            var entry = await _table.AddAsync(entity);
            return _context.Entry(entry).State == EntityState.Added;
        }
        public void AddRange(IEnumerable<T> entities)
            => _table.AddRange(entities);
        public async Task AddRangeAsync(IEnumerable<T> entities)
            => await _table.AddRangeAsync(entities);
        //todo Delete repositories 
        public void Delete(long id)
        {
            var entity = GetById(true, id);
            _context.Remove(entity);
        }
        public void DeleteRange(IEnumerable<T> entities)
        => _context.RemoveRange(entities);

        public void Delete(T entity)
        => _context.Remove(entity);
        public async Task DeleteAsync(long id)
        {
            var entity = await GetByIdAsync(true, id);
            _context.Remove(entity);
        }
        public void DeleteRange(Expression<Func<T, bool>> predicate)
        {
            var entities = GetAll(true).Where(predicate).AsEnumerable();
            DeleteRange(entities);
        }

        //todo update repositories
        public bool Update(T entity)
        {
            var entry = _table.Update(entity);
            return entry.State == EntityState.Modified;
        }

        //todo get repositories
        public T GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _table.Find(keyValues);
            if (entity is null)
                return null;

            if (!tracking)
                _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }
        public async Task<T> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _table.FindAsync(keyValues);

            if (entity is null)
                return null;

            if (!tracking)
                _context.Entry(entity).State = EntityState.Detached;

            return entity;

        }
        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate, bool tracking = false)
        {
            var entity = await _table.FirstOrDefaultAsync(predicate);

            if (entity is null)
                return null;

            if (!tracking)
                _context.Entry(entity).State = EntityState.Detached;

            return entity;

        }
        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate, bool tracking = false)
        {
            var entity = _table.FirstOrDefault(predicate);

            if (entity is null)
                return null;

            if (!tracking)
                _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public IEnumerable<T> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            if (paginationModel is null)
                paginationModel = new();

            var query = _table.AsQueryable();

            if (!tracking)
                query = query.AsNoTracking();

            query = query
                .Take(paginationModel.PageSize)
                .Skip((paginationModel.PageNumber - 1) * paginationModel.PageSize);

            return query.AsEnumerable();
        }

        public IQueryable<T> GetAll(bool tracking = false)
        {
            if (!tracking)
                return _table.AsNoTracking();

            return _table.AsQueryable();

        }

        public IEnumerable<T> GetAll(PaginationModel paginationModel,
            Expression<Func<T, bool>> predicate,
            Expression<Func<T, long>> orderByKeySelector,
            OrderByDirection direction,
            bool tracking = false,
            params Expression<Func<T, long>>[] thenByKeySelector)
        {
            IOrderedQueryable<T> orderedQueryable;

            var query = GetAll(tracking);

            if (predicate is not null)
                query = query.Where(predicate);


            if (orderByKeySelector is not null)
            {
                orderedQueryable = direction switch
                {
                    OrderByDirection.Ascending => query.OrderBy(orderByKeySelector),
                    OrderByDirection.Descending => query.OrderByDescending(orderByKeySelector),
                    _ => query.OrderBy(orderByKeySelector)
                };

                foreach (var keySelector in thenByKeySelector)
                    orderedQueryable = orderedQueryable.ThenBy(keySelector);


                return orderedQueryable
                             .Take(paginationModel.PageSize)
                             .Skip((paginationModel.PageNumber - 1) * paginationModel.PageSize)
                             .AsEnumerable();
            }

            return query
               .Take(paginationModel.PageSize)
               .Skip((paginationModel.PageNumber - 1) * paginationModel.PageSize)
               .AsEnumerable();

        }

        public async Task<IEnumerable<T>> GetAllAsync(
            PaginationModel paginationModel,
            Expression<Func<T, bool>> predicate,
            Expression<Func<T, long>> orderByKeySelector,
            OrderByDirection direction,
            bool tracking = false,
            params Expression<Func<T, long>>[] thenByKeySelector)
        {
            IOrderedQueryable<T> orderedQueryable;

            var query = GetAll(tracking);

            if (predicate is not null)
                query = query.Where(predicate);


            if (orderByKeySelector is not null)
            {
                orderedQueryable = (direction switch
                {
                    OrderByDirection.Ascending => query.OrderBy(orderByKeySelector),
                    OrderByDirection.Descending => query.OrderByDescending(orderByKeySelector),
                    _ => query.OrderBy(orderByKeySelector)
                })
                ;

                foreach (var keySelector in thenByKeySelector)
                    orderedQueryable = orderedQueryable.ThenBy(keySelector);

                return await orderedQueryable
                              .Take(paginationModel.PageSize)
                              .Skip((paginationModel.PageNumber - 1) * paginationModel.PageSize)
                              .ToListAsync();
            }

            return await query
                             .Take(paginationModel.PageSize)
                             .Skip((paginationModel.PageNumber - 1) * paginationModel.PageSize)
                             .ToListAsync();
        }
        public Task<T> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        //todo savechanges metots
        public int SaveChanges()
           => _context.SaveChanges();
        public async Task<int> SaveChangesAsync()
            => await _context.SaveChangesAsync();
    }
}
