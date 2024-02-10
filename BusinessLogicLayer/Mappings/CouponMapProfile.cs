using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class CouponMapProfile : Profile
    {

        public CouponMapProfile()
        {
            CreateMap<Coupon,CouponDto>().ReverseMap();
        }
    }


}
