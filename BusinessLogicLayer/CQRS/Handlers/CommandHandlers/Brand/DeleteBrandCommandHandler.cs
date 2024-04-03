using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Brand;
using BusinessLogicLayer.CQRS.Commands.Responses.Brand;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Brand
{
    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommandRequest, DeleteBrandCommandResponse>
    {
        IMapper _mapper;
        IBrandService _brandService;

        public DeleteBrandCommandHandler(IMapper mapper, IBrandService brandService)
        {
            _mapper = mapper;
            _brandService = brandService;
        }

        public Task<DeleteBrandCommandResponse> Handle(DeleteBrandCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<BrandDto>(request);

            var resultDto = _brandService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteBrandCommandResponse>(resultDto));

        }
    }
}
