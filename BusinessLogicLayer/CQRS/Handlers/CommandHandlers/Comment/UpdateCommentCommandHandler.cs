using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Comment;
using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Comment
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommandRequest, (UpdateCommentCommandResponse, UpdateCommentCommandResponse)>
    {
        IMapper _mapper;
        IValidator<CommentDto> _validator;
        ICommentService _commentService;

        public UpdateCommentCommandHandler(IMapper mapper, IValidator<CommentDto> validator, ICommentService commentService)
        {
            _mapper = mapper;
            _validator = validator;
            _commentService = commentService;
        }

        public async Task<(UpdateCommentCommandResponse, UpdateCommentCommandResponse)> Handle(UpdateCommentCommandRequest request, CancellationToken cancellationToken)
        {

            var dto = _mapper.Map<CommentDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _commentService.Update(dto);
            var old = _mapper.Map<UpdateCommentCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateCommentCommandResponse>(tupleDto.Item2);

            return (old, @new);

        }
    }
}
