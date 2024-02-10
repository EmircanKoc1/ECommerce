using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class ClaimMapProfile : Profile
    {
        public ClaimMapProfile()
        {
            CreateMap<Claim,ClaimDto>().ReverseMap();
        }

    }


}
