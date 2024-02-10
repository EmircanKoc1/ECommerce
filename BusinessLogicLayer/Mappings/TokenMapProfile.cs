using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class TokenMapProfile : Profile
    {
        public TokenMapProfile()
        {
            CreateMap<Token, TokenDto>().ReverseMap();
        }

    }


}
