using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class ProductMapProfile : Profile
    {

        public ProductMapProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
        }
    }


}
