using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.ShipmentCompany;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IShipmentCompanyReadService : IReadService<ShipmentCompanyForReadDto,ShipmentCompany>
    {
    }
}
