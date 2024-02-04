using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.ShipmentCompany
{
    public record ShipmentCompanyForReadDto : BaseDtoForRead
    {
        public string Name { get; init; }
    }
}
