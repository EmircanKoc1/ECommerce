using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class ProductImageMapProfile : Profile
    {

        public ProductImageMapProfile()
        {
            CreateMap<ProductImageDto, ProductImage>().ReverseMap();
        }
    }


}
