using CoreLayer.DTOs;
using DataAccessLayer.Entities.Base.Concretes;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Abstracts.Base
{
    public interface IBaseWriteService<TDto, TEntity>
    where TEntity : BaseEntity
    where TDto : BaseDto
    {
        public TDto Add(TDto dto);
        public Task<TDto> AddAsync(TDto dto);
        public IEnumerable<TDto> AddRange(IEnumerable<TDto> dtos);
        public Task<IEnumerable<TDto>> AddRangeAsync(IEnumerable<TDto> dtos);
        public TDto Delete(long id);
        public IEnumerable<TDto> DeleteRange(IEnumerable<TDto> dtos);
        public TDto Delete(TDto dtos);
        public Task<TDto> DeleteAsync(long id);
        public IEnumerable<TDto> DeleteRange(Expression<Func<TEntity, bool>> predicate);

        public (TDto, TDto) Update(TDto dtos);
    }
}
