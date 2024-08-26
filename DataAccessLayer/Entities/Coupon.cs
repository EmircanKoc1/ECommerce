using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Coupon : BaseEntity
    {
        public Coupon() => Orders = new HashSet<Order>();


        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public float MinimumPrice { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
