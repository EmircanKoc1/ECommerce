using BusinessLogicLayer.CQRS.Commands.Responses.Order;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Order
{
    public class DeleteOrderCommandRequest : IRequest<DeleteOrderCommandResponse>
    {
    }
}
