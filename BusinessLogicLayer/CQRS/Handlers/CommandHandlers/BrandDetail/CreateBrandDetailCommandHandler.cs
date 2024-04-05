using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Brand;
using BusinessLogicLayer.CQRS.Commands.Requests.BrandDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.Brand;
using BusinessLogicLayer.CQRS.Commands.Responses.BrandDetail;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.BrandDetail
{
    public class CreateBrandDetailCommandHandler : IRequestHandler<CreateBrandDetailCommandRequest,
        CreateBrandDetailCommandResponse>
    {
        IBrandDetailService _brandDetailService;
        IMapper _mapper;
        IValidator<BrandDetailDto> _validator;

        public CreateBrandDetailCommandHandler(IBrandDetailService brandDetailService, IMapper mapper, IValidator<BrandDetailDto> validator)
        {
            _brandDetailService = brandDetailService;
            _mapper = mapper;
            _validator = validator;
        }
      
       
        public async Task<CreateBrandDetailCommandResponse> Handle(CreateBrandDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var brandDetailDto = _mapper.Map<BrandDetailDto>(request);
            var validationResult = await _validator.ValidateAsync(brandDetailDto);

            if (!validationResult.IsValid)
                return null;
            
            var responseDto = await _brandDetailService.AddAsync(brandDetailDto);

            return _mapper.Map<CreateBrandDetailCommandResponse>(responseDto);


        }
    }
}
