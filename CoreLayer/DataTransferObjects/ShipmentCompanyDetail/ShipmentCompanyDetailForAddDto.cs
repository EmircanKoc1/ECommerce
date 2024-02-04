using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.ShipmentCompanyDetail
{
    public record ShipmentCompanyDetailForAddDto : BaseDtoForAdd
    {
        public int TotalShipmentCount { get; init; }
        public int TotalFailedShipmentCount { get; init; }
        public int TotalSuccessfulShipmentCount { get; init; }
        public string Description { get; init; }
        public DateTime? FoundedYear { get; init; }
        public long? ShipmentCompanyId { get; init; }
    }
}
