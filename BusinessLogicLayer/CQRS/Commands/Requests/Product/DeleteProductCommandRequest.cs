using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Product
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
    }
}
