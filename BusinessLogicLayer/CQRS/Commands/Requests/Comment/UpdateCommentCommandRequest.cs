using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Comment
{
    public class UpdateCommentCommandRequest : BaseRequest, IRequest<(UpdateCommentCommandResponse, UpdateCommentCommandResponse)>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public byte Score { get; set; }
        public long? ProductId { get; set; }
        public long? UserId { get; set; }

    }
}
