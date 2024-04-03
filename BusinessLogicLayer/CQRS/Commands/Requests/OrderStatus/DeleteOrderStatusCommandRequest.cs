using BusinessLogicLayer.CQRS.Commands.Responses.OrderStatus;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.OrderStatus
{
    public class DeleteOrderStatusCommandRequest : IRequest<DeleteOrderStatusCommandResponse>
    {
    }
}
