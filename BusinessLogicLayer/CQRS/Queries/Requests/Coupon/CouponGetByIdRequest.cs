using BusinessLogicLayer.CQRS.Queries.Responses.Coupon;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Coupon
{
    public class CouponGetByIdRequest : IRequest<CouponGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
