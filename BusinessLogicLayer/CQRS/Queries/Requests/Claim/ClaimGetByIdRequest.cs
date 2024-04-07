using BusinessLogicLayer.CQRS.Queries.Responses.Claim;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Claim
{
    public class ClaimGetByIdRequest : IRequest<ClaimGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
