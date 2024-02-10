using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class UserService : IUserService
    {
        public UserDto Add(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> AddAsync(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> AddRange(IEnumerable<UserDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> AddRangeAsync(IEnumerable<UserDto> dtos)
        {
            throw new NotImplementedException();
        }

        public UserDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public UserDto Delete(UserDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> DeleteRange(IEnumerable<UserDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> DeleteRange(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetAll(PaginationModel paginationModel, Expression<Func<User, bool>> predicate, Expression<Func<User, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<User, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<User, bool>> predicate, Expression<Func<User, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<User, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public UserDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public UserDto GetFirstOrDefault(Expression<Func<User, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetFirstOrDefaultAsync(Expression<Func<User, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (UserDto, UserDto) Update(UserDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
