using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Coupon;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface ICouponReadService : IReadService<CouponForReadDto,Coupon>
    {
    }
}
