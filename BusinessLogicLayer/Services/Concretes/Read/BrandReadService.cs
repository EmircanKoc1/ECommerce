using BusinessLogicLayer.Services.Abstracts.Read;
using CoreLayer.DataTransferObjects.Brand;
using CoreLayer.DataTransferObjects.BrandDetail;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes.Read
{
    public class BrandReadService : IBrandReadService
    {
        public IEnumerable<BrandForReadDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandForReadDto> GetAll(bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BrandForReadDto> GetAll(PaginationModel paginationModel, Expression<Func<Brand, bool>> predicate, Expression<Func<Brand, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Brand, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BrandForReadDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Brand, bool>> predicate, Expression<Func<Brand, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Brand, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public BrandForReadDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<BrandForReadDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<BrandForReadDto> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<Brand, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public BrandForReadDto GetFirstOrDefault(Expression<Func<Brand, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<BrandForReadDto> GetFirstOrDefaultAsync(Expression<Func<Brand, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }
    }

}
