using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class UserMapProfile : Profile
    {

        public UserMapProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }


}
