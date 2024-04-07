using BusinessLogicLayer.CQRS.Queries.Responses.ProductFeature;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.ProductFeature
{
    public class ProductFeatureGetByIdRequest : IRequest<ProductFeatureGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
