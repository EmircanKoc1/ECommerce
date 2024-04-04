using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Coupon;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Coupon
{
    public class DeleteCouponCommandRequest : BaseRequest, IRequest<DeleteCouponCommandResponse>
    {
    }
}
