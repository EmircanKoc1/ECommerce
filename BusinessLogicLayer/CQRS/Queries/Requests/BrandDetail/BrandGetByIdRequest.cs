using BusinessLogicLayer.CQRS.Queries.Responses.Brand;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.BrandDetail
{
    public class BrandGetByIdRequest : IRequest<BrandGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
