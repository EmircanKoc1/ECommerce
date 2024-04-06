using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Product;
using BusinessLogicLayer.CQRS.Commands.Requests.ProductFeature;
using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductFeature;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ProductFeature
{
    public class CreateProductFeatureCommandHandler : IRequestHandler<CreateProductFeatureCommandRequest, CreateProductFeatureCommandResponse>
    {
        IMapper _mapper;
        IValidator<ProductFeatureDto> _validator;
        IProductFeatureService _productFeatureService;

        public CreateProductFeatureCommandHandler(IMapper mapper, IValidator<ProductFeatureDto> validator, IProductFeatureService productFeatureService)
        {
            _mapper = mapper;
            _validator = validator;
            _productFeatureService = productFeatureService;
        }

        public async Task<CreateProductFeatureCommandResponse> Handle(CreateProductFeatureCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ProductFeatureDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;

            var responseDto = await _productFeatureService.AddAsync(dto);

            return _mapper.Map<CreateProductFeatureCommandResponse>(responseDto);



        }
    }
}
