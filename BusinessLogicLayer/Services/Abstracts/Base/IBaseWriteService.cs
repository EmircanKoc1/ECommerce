using CoreLayer.DTOs;
using DataAccessLayer.Entities.Base.Concretes;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Abstracts.Base
{
    public interface IBaseWriteService<TDto , TEntity>
    where TEntity : BaseEntity
    where TDto : BaseDto
    {
        public TDto Add(TDto dto);
        public Task<bool> AddAsync(TDto dto);
        public bool AddRange(IEnumerable<TDto> dtos);
        public Task AddRangeAsync(IEnumerable<TDto> dtos);
        public bool Delete(long id);
        public bool DeleteRange(IEnumerable<TDto> dtos);
        public bool Delete(TDto dtos);
        public Task<bool> DeleteAsync(long id);
        public bool DeleteRange(Expression<Func<TEntity, bool>> predicate);

        public bool Update(TDto dtos);
    }
}
