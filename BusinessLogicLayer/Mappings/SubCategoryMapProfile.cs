using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class SubCategoryMapProfile : Profile
    {

        public SubCategoryMapProfile()
        {
            CreateMap<SubCategory,SubCategoryDto>().ReverseMap();
        }
    }


}
