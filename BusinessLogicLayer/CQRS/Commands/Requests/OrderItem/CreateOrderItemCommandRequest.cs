using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.OrderItem;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.OrderItem
{
    public class CreateOrderItemCommandRequest : IRequest<CreateOrderItemCommandResponse>
    {
    }
}
