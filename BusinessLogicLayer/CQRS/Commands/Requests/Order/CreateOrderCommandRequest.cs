using BusinessLogicLayer.CQRS.Commands.Responses.Order;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Order
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
    }
}
