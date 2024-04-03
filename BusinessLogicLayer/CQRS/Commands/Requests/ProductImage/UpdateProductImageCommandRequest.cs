using BusinessLogicLayer.CQRS.Commands.Responses.ProductImage;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ProductImage
{
    public class UpdateProductImageCommandRequest : IRequest<(UpdateProductImageCommandResponse, UpdateProductImageCommandResponse)>
    {
    }
}
