using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class BrandMapProfile : Profile
    {
        public BrandMapProfile()
        {
            CreateMap<Brand,BrandDto>().ReverseMap();
        }

    }


}
