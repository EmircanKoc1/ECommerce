using BusinessLogicLayer.Services.Abstracts.Read;
using CoreLayer.DataTransferObjects.BrandDetail;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes.Read
{
    public class BrandDetailReadService : IBrandDetailReadService
    {
        public IEnumerable<BrandDetailForReadDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDetailForReadDto> GetAll(bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BrandDetailForReadDto> GetAll(PaginationModel paginationModel, Expression<Func<BrandDetail, bool>> predicate, Expression<Func<BrandDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<BrandDetail, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BrandDetailForReadDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<BrandDetail, bool>> predicate, Expression<Func<BrandDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<BrandDetail, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public BrandDetailForReadDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDetailForReadDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDetailForReadDto> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<BrandDetail, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public BrandDetailForReadDto GetFirstOrDefault(Expression<Func<BrandDetail, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDetailForReadDto> GetFirstOrDefaultAsync(Expression<Func<BrandDetail, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }
    }

}
