using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class OrderStatus : BaseEntity
    {

        public long OrderId { get; set; }
        public Order Order { get; set; }
        public string Description { get; set; }
        public bool IsPreparing { get; set; }
        public bool IsCancel { get; set; }
        public bool IsFinal { get; set; }
        public bool IsShipment { get; set; }

    }
}
