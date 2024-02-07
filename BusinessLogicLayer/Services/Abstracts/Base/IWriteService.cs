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
        public bool Add(TAddForDto dto);
        public  Task<bool> AddAsync(TAddForDto dto);
        public void AddRange(IEnumerable<TAddForDto> dtos);
        public  Task AddRangeAsync(IEnumerable<TAddForDto> dtos);

        public bool Delete(long id);
        public void DeleteRange(IEnumerable<TDeleteForDto> dtos);
        public bool Delete(TDeleteForDto dtos);
        public  Task<bool> DeleteAsync(long id);
        public void DeleteRange(Expression<Func<TDeleteForDto, bool>> predicate);

        public bool Update(TUpdateForDto dtos);
       


    }
}
