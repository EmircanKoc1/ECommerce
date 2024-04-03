using BusinessLogicLayer.CQRS.Commands.Responses.Tag;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Tag
{
    public class CreateTagCommandRequest : IRequest<CreateTagCommandResponse>
    {
    }
}
