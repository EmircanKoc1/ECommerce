using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.ShipmentCompanyDetail;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IShipmentCompanyDetailWriteService : IWriteService<ShipmentCompanyDetailForUpdateDto, ShipmentCompanyDetailForDeleteDto, ShipmentCompanyDetailForAddDto, ShipmentCompanyDetail>
    {
    }

}
