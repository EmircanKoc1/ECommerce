using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class TagMapProfile : Profile
    {

        public TagMapProfile()
        {
            CreateMap<Tag, TagDto>().ReverseMap();
        }
    }


}
