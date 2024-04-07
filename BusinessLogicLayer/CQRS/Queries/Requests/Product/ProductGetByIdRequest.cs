using BusinessLogicLayer.CQRS.Queries.Responses.Product;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Product
{
    public class ProductGetByIdRequest : IRequest<ProductGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
