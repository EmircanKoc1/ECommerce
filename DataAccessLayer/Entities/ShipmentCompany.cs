using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class ShipmentCompany : BaseEntity
    {
        public ShipmentCompany() => Orders = new HashSet<Order>();


        public string Name { get; set; }

        public ShipmentCompanyDetail ShipmentDetail { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
