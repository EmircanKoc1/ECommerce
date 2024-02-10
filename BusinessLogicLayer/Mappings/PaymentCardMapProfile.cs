using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class PaymentCardMapProfile : Profile
    {

        public PaymentCardMapProfile()
        {
            CreateMap<PaymentCard, PaymentCardDto>().ReverseMap();
        }
    }


}
