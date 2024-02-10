using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class OrderStatusMapProfile : Profile
    {

        public OrderStatusMapProfile()
        {
            CreateMap<OrderStatus,OrderStatusDto>().ReverseMap();
        }
    }


}
