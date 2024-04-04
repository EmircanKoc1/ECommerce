using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Product
{
    public class DeleteProductCommandRequest :BaseRequest, IRequest<DeleteProductCommandResponse>
    {
    }
}
