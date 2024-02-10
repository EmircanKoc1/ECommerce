using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class ClaimService : IClaimService
    {
        public ClaimDto Add(ClaimDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ClaimDto> AddAsync(ClaimDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClaimDto> AddRange(IEnumerable<ClaimDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClaimDto>> AddRangeAsync(IEnumerable<ClaimDto> dtos)
        {
            throw new NotImplementedException();
        }

        public ClaimDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public ClaimDto Delete(ClaimDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<ClaimDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClaimDto> DeleteRange(IEnumerable<ClaimDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClaimDto> DeleteRange(Expression<Func<Claim, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClaimDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClaimDto> GetAll(PaginationModel paginationModel, Expression<Func<Claim, bool>> predicate, Expression<Func<Claim, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Claim, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClaimDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Claim, bool>> predicate, Expression<Func<Claim, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Claim, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public ClaimDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<ClaimDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public ClaimDto GetFirstOrDefault(Expression<Func<Claim, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<ClaimDto> GetFirstOrDefaultAsync(Expression<Func<Claim, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (ClaimDto, ClaimDto) Update(ClaimDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
