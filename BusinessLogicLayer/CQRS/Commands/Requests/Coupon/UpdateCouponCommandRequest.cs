using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Coupon
{
    public class UpdateCouponCommandRequest : IRequest<(UpdateCommentCommandResponse, UpdateCommentCommandResponse)>
    {
    }
}
