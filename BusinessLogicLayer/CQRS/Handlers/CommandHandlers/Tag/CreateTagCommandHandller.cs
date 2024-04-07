using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Tag;
using BusinessLogicLayer.CQRS.Commands.Responses.Tag;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Tag
{
    public class CreateTagCommandHandller : IRequestHandler<CreateTagCommandRequest, CreateTagCommandResponse>
    {
        IMapper _mapper;
        ITagService _tagService;
        IValidator<TagDto> _validator;

        public CreateTagCommandHandller(IMapper mapper, ITagService tagService, IValidator<TagDto> validator)
        {
            _mapper = mapper;
            _tagService = tagService;
            _validator = validator;
        }

        public async Task<CreateTagCommandResponse> Handle(CreateTagCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<TagDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);
            if (!validationResult.IsValid)
                return null;

            var responseDto = _tagService.AddAsync(dto);

            return _mapper.Map<CreateTagCommandResponse>(responseDto);
        }
    }
}
