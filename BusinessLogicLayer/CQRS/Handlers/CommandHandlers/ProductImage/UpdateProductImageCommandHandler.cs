using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ProductImage;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductImage;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ProductImage
{
    public class UpdateProductImageCommandHandler : IRequestHandler<UpdateProductImageCommandRequest, (UpdateProductImageCommandResponse, UpdateProductImageCommandResponse)>
    {
        IMapper _mapper;
        IValidator<ProductImageDto> _validator;
        IProductImageService _productImageService;

        public UpdateProductImageCommandHandler(IMapper mapper, IValidator<ProductImageDto> validator, IProductImageService productImageService)
        {
            _mapper = mapper;
            _validator = validator;
            _productImageService = productImageService;
        }

        public async Task<(UpdateProductImageCommandResponse, UpdateProductImageCommandResponse)> Handle(UpdateProductImageCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ProductImageDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);


            var tupleDto = _productImageService.Update(dto);
            var old = _mapper.Map<UpdateProductImageCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateProductImageCommandResponse>(tupleDto.Item2);

            return (old, @new);

        }
    }
}
