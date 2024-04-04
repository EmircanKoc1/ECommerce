using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Tag;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Tag
{
    public class UpdateTagCommandRequest : BaseRequest, IRequest<(UpdateTagCommandResponse, UpdateTagCommandResponse)>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
