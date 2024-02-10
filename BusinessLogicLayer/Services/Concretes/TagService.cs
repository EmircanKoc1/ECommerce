using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class TagService : ITagService
    {
        public TagDto Add(TagDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<TagDto> AddAsync(TagDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TagDto> AddRange(IEnumerable<TagDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TagDto>> AddRangeAsync(IEnumerable<TagDto> dtos)
        {
            throw new NotImplementedException();
        }

        public TagDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public TagDto Delete(TagDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<TagDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TagDto> DeleteRange(IEnumerable<TagDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TagDto> DeleteRange(Expression<Func<Tag, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TagDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TagDto> GetAll(PaginationModel paginationModel, Expression<Func<Tag, bool>> predicate, Expression<Func<Tag, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Tag, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TagDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Tag, bool>> predicate, Expression<Func<Tag, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Tag, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public TagDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<TagDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public TagDto GetFirstOrDefault(Expression<Func<Tag, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<TagDto> GetFirstOrDefaultAsync(Expression<Func<Tag, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (TagDto, TagDto) Update(TagDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
