using BusinessLogicLayer.Services.Abstracts.Read;
using CoreLayer.DataTransferObjects.Claim;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes.Read
{
    public class ClaimReadService : IClaimReadService
    {
        public IEnumerable<ClaimForReadDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClaimForReadDto> GetAll(bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ClaimForReadDto> GetAll(PaginationModel paginationModel, Expression<Func<Claim, bool>> predicate, Expression<Func<Claim, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Claim, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClaimForReadDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Claim, bool>> predicate, Expression<Func<Claim, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Claim, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public ClaimForReadDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<ClaimForReadDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<ClaimForReadDto> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<Claim, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public ClaimForReadDto GetFirstOrDefault(Expression<Func<Claim, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<ClaimForReadDto> GetFirstOrDefaultAsync(Expression<Func<Claim, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }
    }

}
