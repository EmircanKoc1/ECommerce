using BusinessLogicLayer.CQRS.Commands.Responses.Claim;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Claim
{
    public class CreateClaimCommandRequest : IRequest<CreateClaimCommandResponse>
    {
        public string ClaimType { get; set; }
        public string ClaimName { get; set; }
    }
}
