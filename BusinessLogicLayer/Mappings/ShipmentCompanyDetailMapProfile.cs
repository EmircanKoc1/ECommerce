using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class ShipmentCompanyDetailMapProfile : Profile
    {
        public ShipmentCompanyDetailMapProfile()
        {
         CreateMap<ShipmentCompanyDetail,ShipmentCompanyDetailDto>().ReverseMap();   
        }

    }


}
