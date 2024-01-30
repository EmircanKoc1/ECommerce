using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Order : ModifiableBaseEntity
    {

        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public int DiscountAmount { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }


        public long OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public long CouponId { get; set; }
        public Coupon Coupon { get; set; }

        public long ShipmentCompanyId { get; set; }
        public ShipmentCompany ShipmentCompany { get; set; }

    }
}
