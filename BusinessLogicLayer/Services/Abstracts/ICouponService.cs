using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface ICouponService : IBaseReadService<CouponDto, Coupon>, IBaseWriteService<CouponDto, Coupon>
    {
    }
}
