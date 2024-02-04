using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Order
{
    public record OrderForUpdateDto : BaseDtoForUpdate
    {
        public DateTime OrderDate { get; init; }
        public float TotalAmount { get; init; }
        public float DiscountAmount { get; init; }
        public long? UserId { get; init; }
        public long? AddressId { get; init; }
        public long? CouponId { get; init; }
        public long? ShipmentCompanyId { get; init; }

    }
}
