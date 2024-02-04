using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.Coupon
{
    public record CouponForAddDto : BaseDtoForAdd
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string Code { get; init; }
        public float MinimumPrice { get; init; }
        public float DiscountAmount { get; init; }
        public DateTime? ExpirationDate { get; init; }

    }
}
