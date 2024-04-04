using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Coupon
{
    public class CreateCouponCommandRequest : IRequest<CreateAddressCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public float MinimumPrice { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }


    }
}
