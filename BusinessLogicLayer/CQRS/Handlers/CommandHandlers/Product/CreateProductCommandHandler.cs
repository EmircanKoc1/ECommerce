using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Product;
using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Product
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        IMapper _mapper;
        IValidator<ProductDto> _validator;
        IProductService _productService;

        public CreateProductCommandHandler(IMapper mapper, IValidator<ProductDto> validator, IProductService productService)
        {
            _mapper = mapper;
            _validator = validator;
            _productService = productService;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ProductDto>(request);
            var validationResult = await  _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;

            var responseDto = _productService.AddAsync(dto);

            return _mapper.Map<CreateProductCommandResponse>(responseDto);
        }
    }
}
