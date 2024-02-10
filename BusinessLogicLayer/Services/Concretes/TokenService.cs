using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class TokenService : ITokenService
    {
        public TokenDto Add(TokenDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<TokenDto> AddAsync(TokenDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TokenDto> AddRange(IEnumerable<TokenDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TokenDto>> AddRangeAsync(IEnumerable<TokenDto> dtos)
        {
            throw new NotImplementedException();
        }

        public TokenDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public TokenDto Delete(TokenDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<TokenDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TokenDto> DeleteRange(IEnumerable<TokenDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TokenDto> DeleteRange(Expression<Func<Token, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TokenDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TokenDto> GetAll(PaginationModel paginationModel, Expression<Func<Token, bool>> predicate, Expression<Func<Token, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Token, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TokenDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Token, bool>> predicate, Expression<Func<Token, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Token, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public TokenDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<TokenDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public TokenDto GetFirstOrDefault(Expression<Func<Token, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<TokenDto> GetFirstOrDefaultAsync(Expression<Func<Token, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (TokenDto, TokenDto) Update(TokenDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
