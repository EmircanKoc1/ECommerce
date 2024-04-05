using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using BusinessLogicLayer.CQRS.Commands.Responses.Coupon;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Coupon
{
    public class UpdateCouponCommandRequest : BaseRequest,IRequest<(UpdateCouponCommandResponse, UpdateCouponCommandResponse)>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public float MinimumPrice { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
