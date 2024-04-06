using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ProductFeature;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductFeature;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ProductFeature
{
    public class UpdateProductFeatureCommandHandler : IRequestHandler<UpdateProductFeatureCommandRequest, (UpdateProductFeatureCommandResponse, UpdateProductFeatureCommandResponse)>
    {
        IMapper _mapper;
        IProductFeatureService _productFeatureService;
        IValidator<ProductFeatureDto> _validator;

        public UpdateProductFeatureCommandHandler(IMapper mapper, IProductFeatureService productFeatureService, IValidator<ProductFeatureDto> validator)
        {
            _mapper = mapper;
            _productFeatureService = productFeatureService;
            _validator = validator;
        }

        public async Task<(UpdateProductFeatureCommandResponse, UpdateProductFeatureCommandResponse)> Handle(UpdateProductFeatureCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ProductFeatureDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _productFeatureService.Update(dto);

            var old = _mapper.Map<UpdateProductFeatureCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateProductFeatureCommandResponse>(tupleDto.Item2);

            return (old, @new);

        }
    }
}
