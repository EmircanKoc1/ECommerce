using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductImage;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ProductImage
{
    public class UpdateProductImageCommandRequest : BaseRequest,IRequest<(UpdateProductImageCommandResponse, UpdateProductImageCommandResponse)>
    {
        public string ImagePath { get; set; }
        public long? ProductId { get; set; }
    }
}
