using BusinessLogicLayer.CQRS.Commands.Responses.Coupon;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Coupon
{
    public class DeleteCouponCommandRequest : IRequest<DeleteCouponCommandResponse>
    {
    }
}
