using AutoMapper;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class ShipmentCompanyMapProfile : Profile
    {

        public ShipmentCompanyMapProfile()
        {
            CreateMap<ShipmentCompany, ShipmentCompanyDto>().ReverseMap();
        }
    }


}
