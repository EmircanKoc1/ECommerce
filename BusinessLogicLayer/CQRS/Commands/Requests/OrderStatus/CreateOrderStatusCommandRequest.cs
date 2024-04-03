using BusinessLogicLayer.CQRS.Commands.Responses.OrderStatus;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.OrderStatus
{
    public class CreateOrderStatusCommandRequest : IRequest<CreateOrderStatusCommandResponse>
    {
    }
}
