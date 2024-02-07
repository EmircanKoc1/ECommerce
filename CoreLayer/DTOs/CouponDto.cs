namespace CoreLayer.DTOs
{
    public class CouponDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public float MinimumPrice { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public ICollection<OrderDto> Orders { get; set; }
    }
}
