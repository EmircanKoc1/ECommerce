using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Coupon;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface ICouponWriteService : IWriteService<CouponForUpdateDto, CouponForDeleteDto, CouponForAddDto, Coupon>
    {

    }

}
