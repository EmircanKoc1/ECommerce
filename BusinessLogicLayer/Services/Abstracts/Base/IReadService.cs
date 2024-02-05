using CoreLayer.DataTransferObjects.Base;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities.Base.Concretes;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Abstracts.Base
{
    public interface IReadService<TReadForDto, TEntity>
    where TReadForDto : BaseDtoForRead
    where TEntity : BaseEntity
    {
        TReadForDto GetById(bool tracking = false, params object[] keyValues);
        Task<TReadForDto> GetByIdAsync(bool tracking = false, params object[] keyValues);
        TReadForDto GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate, bool tracking = false);
        Task<TReadForDto> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = false);
        IEnumerable<TReadForDto> GetAll(PaginationModel paginationModel, bool tracking = false);
        IEnumerable<TReadForDto> GetAll(bool tracking = false);
        IQueryable<TReadForDto> GetAll(PaginationModel paginationModel, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<TEntity, long>>[] thenByKeySelector);
        Task<IEnumerable<TReadForDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<TEntity, long>>[] thenByKeySelector);
        Task<TReadForDto> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<TEntity, object>>[] includes);

    }


}
