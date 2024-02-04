using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Coupon
{
    public record CouponForUpdateDto : BaseDtoForUpdate
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string Code { get; init; }
        public float MinimumPrice { get; init; }
        public float DiscountAmount { get; init; }
        public DateTime? ExpirationDate { get; init; }
    }
}
