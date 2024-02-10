using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class BrandDetailMapProfile : Profile
    {
        public BrandDetailMapProfile()
        {
            CreateMap<BrandDetailDto, BrandDetail>().ReverseMap();
        }

    }


}
