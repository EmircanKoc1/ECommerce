using BusinessLogicLayer.CQRS.Queries.Responses.BrandDetail;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Brand
{
    public class BrandDetailGetByIdRequest : IRequest<BrandDetailGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
