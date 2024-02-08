using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IShipmentCompanyService : IBaseReadService<ShipmentCompanyDto, ShipmentCompany>, IBaseWriteService<ShipmentCompanyDto, ShipmentCompany>
    {
    }
}
