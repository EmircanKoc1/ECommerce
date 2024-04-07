using BusinessLogicLayer.CQRS.Queries.Responses.Comment;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Comment
{
    public class CommentGetByIdRequest : IRequest<CommentGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
