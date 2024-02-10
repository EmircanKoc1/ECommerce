using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class ProductFeatureMapProfile : Profile
    {
        public ProductFeatureMapProfile()
        {
            CreateMap<ProductFeature,ProductFeatureDto>().ReverseMap();
        }

    }


}
