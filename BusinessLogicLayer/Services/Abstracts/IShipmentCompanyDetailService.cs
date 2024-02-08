using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IShipmentCompanyDetailService : IBaseReadService<ShipmentCompanyDetailDto, ShipmentCompanyDetail>, IBaseWriteService<ShipmentCompanyDetailDto, ShipmentCompanyDetail>
    {
    }
}
