using CoreLayer.DataTransferObjects.Base;
using DataAccessLayer.Entities.Base.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Abstracts.Base
{
    public interface IWriteService<TUpdateForDto, TDeleteForDto, TAddForDto, TEntity>
    where TUpdateForDto : BaseDtoForUpdate
    where TDeleteForDto : BaseDtoForDelete
    where TAddForDto : BaseDtoForAdd
    where TEntity : BaseEntity
    {
        public bool Add(TAddForDto entity);
        public  Task<bool> AddAsync(TAddForDto entity);
        public void AddRange(IEnumerable<TAddForDto> entities);
        public  Task AddRangeAsync(IEnumerable<TAddForDto> entities);

        public bool Delete(long id);
        public void DeleteRange(IEnumerable<TDeleteForDto> entities);
        public bool Delete(TDeleteForDto entity);
        public  Task<bool> DeleteAsync(long id);
        public void DeleteRange(Expression<Func<TDeleteForDto, bool>> predicate);

        public bool Update(TUpdateForDto entity);
       


    }
}
