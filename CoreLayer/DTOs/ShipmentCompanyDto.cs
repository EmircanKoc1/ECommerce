using System.Net;

namespace CoreLayer.DTOs
{
    public class ShipmentCompanyDto : BaseDto
    {
        public string Name { get; set; }

        public ShipmentCompanyDetailDto ShipmentDetail { get; set; }

        public ICollection<OrderDto> Orders { get; set; }
    }
}
