using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Comment;
using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Comment
{
    public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommandRequest, DeleteCommentCommandResponse>
    {
        IMapper _mapper;
        ICommentService _commentService;

        public DeleteCommentCommandHandler(IMapper mapper, ICommentService commentService)
        {
            _mapper = mapper;
            _commentService = commentService;
        }

        public Task<DeleteCommentCommandResponse> Handle(DeleteCommentCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<CommentDto>(request);
            var responseDto = _commentService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteCommentCommandResponse>(responseDto));
        }
    }
}
