using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ProductImage;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductImage;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ProductImage
{
    public class DeleteProductImageCommandHandler : IRequestHandler<DeleteProductImageCommandRequest, DeleteProductImageCommandResponse>
    {
        IMapper _mapper;
        IProductImageService _productImageService;

        public DeleteProductImageCommandHandler(IMapper mapper, IProductImageService productImageService)
        {
            _mapper = mapper;
            _productImageService = productImageService;
        }

        public Task<DeleteProductImageCommandResponse> Handle(DeleteProductImageCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ProductImageDto>(request);

            var responseDto = _productImageService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteProductImageCommandResponse>(responseDto));

        }
    }
}
