using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Product;
using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Product
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, (UpdateProductCommandResponse, UpdateProductCommandResponse)>
    {
        IMapper _mapper;
        IValidator<ProductDto> _validator;
        IProductService _productService;

        public UpdateProductCommandHandler(IMapper mapper, IValidator<ProductDto> validator, IProductService productService)
        {
            _mapper = mapper;
            _validator = validator;
            _productService = productService;
        }

        public async Task<(UpdateProductCommandResponse, UpdateProductCommandResponse)> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ProductDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);


            var tupleDto = _productService.Update(dto);
            var old = _mapper.Map<UpdateProductCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateProductCommandResponse>(tupleDto.Item2);

            return (old, @new);


        }
    }
}
