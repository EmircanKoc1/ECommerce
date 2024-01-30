using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class ShipmentDetail : BaseEntity
    {
        public int TotalShipmentCount { get; set; }
        public int TotalFailedShipmentCount { get; set; }
        public int TotalSuccessfulShipmentCount { get; set; }

        public string Description { get; set; }
        public DateTime FoundedYear { get; set; }


    }
}
