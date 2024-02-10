using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class CommentService : ICommentService
    {
        public CommentDto Add(CommentDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> AddAsync(CommentDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentDto> AddRange(IEnumerable<CommentDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommentDto>> AddRangeAsync(IEnumerable<CommentDto> dtos)
        {
            throw new NotImplementedException();
        }

        public CommentDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public CommentDto Delete(CommentDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentDto> DeleteRange(IEnumerable<CommentDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentDto> DeleteRange(Expression<Func<Comment, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentDto> GetAll(PaginationModel paginationModel, Expression<Func<Comment, bool>> predicate, Expression<Func<Comment, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Comment, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommentDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Comment, bool>> predicate, Expression<Func<Comment, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Comment, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public CommentDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public CommentDto GetFirstOrDefault(Expression<Func<Comment, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> GetFirstOrDefaultAsync(Expression<Func<Comment, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (CommentDto, CommentDto) Update(CommentDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
