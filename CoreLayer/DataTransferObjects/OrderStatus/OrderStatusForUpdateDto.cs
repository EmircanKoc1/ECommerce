using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.OrderStatus
{
    public record OrderStatusForUpdateDto : BaseDtoForUpdate
    {
        public long? OrderId { get; init; }
        public string Description { get; init; }
        public bool IsPreparing { get; init; }
        public bool IsCancel { get; init; }
        public bool IsFinal { get; init; }
        public bool IsShipment { get; init; }

    }

}
