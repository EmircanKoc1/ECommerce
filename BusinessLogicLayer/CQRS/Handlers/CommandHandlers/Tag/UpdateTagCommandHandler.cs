using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Tag;
using BusinessLogicLayer.CQRS.Commands.Responses.Tag;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Tag
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommandRequest, (UpdateTagCommandResponse, UpdateTagCommandResponse)>
    {

        private readonly IMapper _mapper;
        private readonly IValidator<TagDto> _validator;
        private readonly ITagService _tagService;

        public UpdateTagCommandHandler(IMapper mapper, IValidator<TagDto> validator, ITagService tagService)
        {
            _mapper = mapper;
            _validator = validator;
            _tagService = tagService;
        }

        public async Task<(UpdateTagCommandResponse, UpdateTagCommandResponse)> Handle(UpdateTagCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<TagDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _tagService.Update(dto);
            var old = _mapper.Map<UpdateTagCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateTagCommandResponse>(tupleDto.Item2);

            return (old, @new);


        }
    }
}
