namespace CoreLayer.DTOs
{
    public class OrderDto : BaseDto
    {
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public float DiscountAmount { get; set; }

        public long? UserId { get; set; }
        public UserDto User { get; set; }

        public OrderStatusDto OrderStatus { get; set; }

        public long? AddressId { get; set; }
        public AddressDto Address { get; set; }

        public ICollection<OrderItemDto> OrderItems { get; set; }

        public long? CouponId { get; set; }
        public CouponDto Coupon { get; set; }

        public long? ShipmentCompanyId { get; set; }
        public ShipmentCompanyDto ShipmentCompany { get; set; }


    }
}
