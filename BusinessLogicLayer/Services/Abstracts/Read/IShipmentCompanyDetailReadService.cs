using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.ShipmentCompanyDetail;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IShipmentCompanyDetailReadService : IReadService<ShipmentCompanyDetailForReadDto, ShipmentCompany>
    {
    }
}
