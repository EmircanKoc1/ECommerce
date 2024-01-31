using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class OrderItem : BaseEntity
    {

        public int Quantity { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }

        public long? OrderId { get; set; }
        public Order Order { get; set; }

        public long? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
