using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Tag;
using BusinessLogicLayer.CQRS.Commands.Responses.Tag;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Tag
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommandRequest, DeleteTagCommandResponse>
    {
        IMapper _mapper;
        ITagService _tagService;

        public DeleteTagCommandHandler(IMapper mapper, ITagService tagService)
        {
            _mapper = mapper;
            _tagService = tagService;
        }

        public Task<DeleteTagCommandResponse> Handle(DeleteTagCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<TagDto>(request);

            var responseDto = _tagService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteTagCommandResponse>(responseDto));

        }
    }
}
