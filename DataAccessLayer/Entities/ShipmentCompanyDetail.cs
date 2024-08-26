using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class ShipmentCompanyDetail : BaseEntity
    {
        public int TotalShipmentCount { get; set; }
        public int TotalFailedShipmentCount { get; set; }
        public int TotalSuccessfulShipmentCount { get; set; }

        public string Description { get; set; }
        public DateTime? FoundedYear { get; set; }

        public long? ShipmentCompanyId { get; set; }
        public ShipmentCompany ShipmentCompany { get; set; }
       

    }
}
