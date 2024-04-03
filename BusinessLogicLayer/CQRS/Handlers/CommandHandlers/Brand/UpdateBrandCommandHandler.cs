using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Brand;
using BusinessLogicLayer.CQRS.Commands.Responses.Brand;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Brand
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest, (UpdateBrandCommandResponse, UpdateBrandCommandResponse)>
    {
        IMapper _mapper;
        IBrandService _brandService;
        IValidator<BrandDto> _validator;

        public UpdateBrandCommandHandler(IMapper mapper, IBrandService brandService, IValidator<BrandDto> validator)
        {
            _mapper = mapper;
            _brandService = brandService;
            _validator = validator;
        }

        public async Task<(UpdateBrandCommandResponse, UpdateBrandCommandResponse)> Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<BrandDto>(request);

            var result = await _validator.ValidateAsync(dto);

            if (!result.IsValid)
                return (null, null);

            var tuple = _brandService.Update(dto);
            var old = _mapper.Map<UpdateBrandCommandResponse>(tuple.Item1);
            var @new = _mapper.Map<UpdateBrandCommandResponse>(tuple.Item2);

            return (old, @new);

        }
    }
}
