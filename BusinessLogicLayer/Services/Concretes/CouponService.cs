using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class CouponService : ICouponService
    {
        public CouponDto Add(CouponDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<CouponDto> AddAsync(CouponDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> AddRange(IEnumerable<CouponDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CouponDto>> AddRangeAsync(IEnumerable<CouponDto> dtos)
        {
            throw new NotImplementedException();
        }

        public CouponDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public CouponDto Delete(CouponDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<CouponDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> DeleteRange(IEnumerable<CouponDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> DeleteRange(Expression<Func<Coupon, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetAll(PaginationModel paginationModel, Expression<Func<Coupon, bool>> predicate, Expression<Func<Coupon, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Coupon, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CouponDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Coupon, bool>> predicate, Expression<Func<Coupon, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Coupon, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public CouponDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<CouponDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public CouponDto GetFirstOrDefault(Expression<Func<Coupon, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<CouponDto> GetFirstOrDefaultAsync(Expression<Func<Coupon, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (CouponDto, CouponDto) Update(CouponDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
