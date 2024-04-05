using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.Coupon;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Coupon
{
    public class CreateCouponCommandRequest : IRequest<CreateCouponCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public float MinimumPrice { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }


    }
}
