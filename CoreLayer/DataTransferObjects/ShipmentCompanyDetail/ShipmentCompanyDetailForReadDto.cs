using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.ShipmentCompanyDetail
{
    public record ShipmentCompanyDetailForReadDto : BaseDtoForRead
    {
        public int TotalShipmentCount { get; init; }
        public int TotalFailedShipmentCount { get; init; }
        public int TotalSuccessfulShipmentCount { get; init; }
        public string Description { get; init; }
        public DateTime? FoundedYear { get; init; }
        public long? ShipmentCompanyId { get; init; }
    }
}
