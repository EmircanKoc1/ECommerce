using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Coupon
{
    public class CreateCouponCommandRequest : IRequest<CreateAddressCommandResponse>
    {
    }
}
