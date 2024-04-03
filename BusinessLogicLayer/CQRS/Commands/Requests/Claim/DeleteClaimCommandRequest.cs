using BusinessLogicLayer.CQRS.Commands.Responses.Claim;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Claim
{
    public class DeleteClaimCommandRequest : IRequest<DeleteClaimCommandResponse>
    {
    }
}
