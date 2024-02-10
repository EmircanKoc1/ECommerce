using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class AddressMapProfile : Profile
    {
        public AddressMapProfile()
        {
            CreateMap<Address, AddressDto>()
                //.ForMember(dest => dest.User, opt => opt.MapFrom(source => source.User))
                .ReverseMap();



        }

    }


}
