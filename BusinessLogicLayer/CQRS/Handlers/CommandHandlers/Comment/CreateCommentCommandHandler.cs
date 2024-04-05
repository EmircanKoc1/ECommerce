using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Comment;
using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Comment
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommandRequest, CreateCommentCommandResponse>
    {
        IMapper _mapper;
        IValidator<CommentDto> _validator;
        ICommentService _commentService;

        public CreateCommentCommandHandler(IMapper mapper, IValidator<CommentDto> validator, ICommentService commentService)
        {
            _mapper = mapper;
            _validator = validator;
            _commentService = commentService;
        }

        public async Task<CreateCommentCommandResponse> Handle(CreateCommentCommandRequest request, CancellationToken cancellationToken)
        {
            var commentDto = _mapper.Map<CommentDto>(request);
            var validationResult = await _validator.ValidateAsync(commentDto);

            if (!validationResult.IsValid)
                return (null);

            var responseDto = await _commentService.AddAsync(commentDto);

            return _mapper.Map<CreateCommentCommandResponse>(responseDto);
        }
    }
}
