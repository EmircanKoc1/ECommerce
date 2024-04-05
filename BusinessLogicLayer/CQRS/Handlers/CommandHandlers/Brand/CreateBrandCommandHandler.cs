using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Brand;
using BusinessLogicLayer.CQRS.Commands.Responses.Brand;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Brand
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, CreateBrandCommandResponse>
    {
        IMapper _mapper;
        IValidator<BrandDto> _validator;
        IBrandService _brandService;
        
        public CreateBrandCommandHandler(IMapper mapper, IValidator<BrandDto> validator, IBrandService brandService)
        {
            _mapper = mapper;
            _validator = validator;
            _brandService = brandService;
        }

        public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<BrandDto>(request);

            var result = await _validator.ValidateAsync(dto);

            if (!result.IsValid)
                return null;

            var responseDto = await _brandService.AddAsync(dto);

            return _mapper.Map<CreateBrandCommandResponse>(responseDto);


        }
    }
}
