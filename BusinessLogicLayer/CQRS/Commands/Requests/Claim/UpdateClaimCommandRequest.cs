using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Claim;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Claim
{
    public class UpdateClaimCommandRequest :  BaseRequest, IRequest<(UpdateClaimCommandResponse, UpdateClaimCommandResponse)>
    {
        public string ClaimType { get; set; }
        public string ClaimName { get; set; }
    }
}
