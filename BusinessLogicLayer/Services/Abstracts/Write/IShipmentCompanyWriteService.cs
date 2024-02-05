using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.ShipmentCompany;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IShipmentCompanyWriteService : IWriteService<ShipmentCompanyForUpdateDto, ShipmentCompanyForDeleteDto, ShipmentCompanyForAddDto, ShipmentCompany>
    {
    }

}
