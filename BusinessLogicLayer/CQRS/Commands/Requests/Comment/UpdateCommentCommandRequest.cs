using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Comment
{
    public class UpdateCommentCommandRequest : IRequest<(UpdateCommentCommandResponse, UpdateCommentCommandResponse)>
    {
    }
}
