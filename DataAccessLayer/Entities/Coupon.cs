using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Coupon : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public float MinimumPrice { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime ExpirationDate { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
