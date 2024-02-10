using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class OrderItemMapProfile : Profile
    {

        public OrderItemMapProfile()
        {
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        }
    }


}
