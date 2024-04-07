using BusinessLogicLayer.CQRS.Queries.Responses.ProductImage;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.ProductImage
{
    public class ProductImageGetByIdRequest : IRequest<ProductImageGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
