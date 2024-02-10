using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities.Base.Concretes;
using DataAccessLayer.Repositories.Abstracts.Base;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Abstracts.Base
{
    public interface IBaseReadService<TDto, TEntity>
    where TDto : BaseDto
    where TEntity : BaseEntity
    {
        
        Task<TDto> GetByIdAsync(bool tracking = false, params object[] keyValues);
        TDto GetById(bool tracking = false, params object[] keyValues);
        Task<TDto> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = false);
        TDto GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate, bool tracking = false);
        IEnumerable<TDto> GetAll(PaginationModel paginationModel, bool tracking = false);
      //  IQueryable<TDto> GetAll(bool tracking = false);

        IEnumerable<TDto> GetAll(
            PaginationModel paginationModel,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, long>> orderByKeySelector,
            OrderByDirection direction,
            bool tracking = false,
            params Expression<Func<TEntity, long>>[] thenByKeySelector);

        Task<IEnumerable<TDto>> GetAllAsync(
           PaginationModel paginationModel,
           Expression<Func<TEntity, bool>> predicate,
           Expression<Func<TEntity, long>> orderByKeySelector,
           OrderByDirection direction,
           bool tracking = false,
           params Expression<Func<TEntity, long>>[] thenByKeySelector);

      //  Task<TDto> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<TEntity, object>>[] includes);
    }
}
