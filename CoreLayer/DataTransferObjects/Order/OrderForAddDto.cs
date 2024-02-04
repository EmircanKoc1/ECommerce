using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.Order
{
    public record OrderForAddDto : BaseDtoForAdd
    {
        public DateTime OrderDate { get; init; }
        public float TotalAmount { get; init; }
        public float DiscountAmount { get; init; }
        public long? UserId { get; init; }
        public long? AddressId { get; init; }
        public long? CouponId { get; init; }
        public long? ShipmentCompanyId { get; init; }

    }
}
