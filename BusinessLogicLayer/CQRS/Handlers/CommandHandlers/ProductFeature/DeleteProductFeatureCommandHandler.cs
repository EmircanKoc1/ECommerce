using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ProductFeature;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductFeature;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ProductFeature
{
    public class DeleteProductFeatureCommandHandler : IRequestHandler<DeleteProductFeatureCommandRequest, DeleteProductFeatureCommandResponse>
    {
        IMapper _mapper;
        IProductFeatureService _productFeatureService;

        public DeleteProductFeatureCommandHandler(IMapper mapper, IProductFeatureService productFeatureService)
        {
            _mapper = mapper;
            _productFeatureService = productFeatureService;
        }

        public Task<DeleteProductFeatureCommandResponse> Handle(DeleteProductFeatureCommandRequest request, CancellationToken cancellationToken)
        {

            var dto = _mapper.Map<ProductFeatureDto>(request);

            var responseDto = _productFeatureService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteProductFeatureCommandResponse>(responseDto));
        }
    }
}
