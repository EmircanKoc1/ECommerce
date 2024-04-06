using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ProductImage;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductImage;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ProductImage
{
    public class CreateProductImageCommandHandler : IRequestHandler<CreateProductImageCommandRequest, CreateProductImageCommandResponse>
    {
        IMapper _mapper;
        IProductImageService _productImageService;
        IValidator<ProductImageDto> _validator;

        public CreateProductImageCommandHandler(IMapper mapper, IProductImageService productImageService, IValidator<ProductImageDto> validator)
        {
            _mapper = mapper;
            _productImageService = productImageService;
            _validator = validator;
        }

        public async Task<CreateProductImageCommandResponse> Handle(CreateProductImageCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ProductImageDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;

            var responseDto = _productImageService.AddAsync(dto);

            return _mapper.Map<CreateProductImageCommandResponse>(responseDto);
        }
    }
}
