using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Product;
using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Product
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        IMapper _mapper;
        IProductService _productService;

        public DeleteProductCommandHandler(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        public Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ProductDto>(request);

            var responseDto = _productService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteProductCommandResponse>(responseDto));

        }
    }
}
