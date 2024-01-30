using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class ShipmentCompany : ModifiableBaseEntity
    {
        public string Name { get; set; }

        public ShipmentDetail ShipmentDetail { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
