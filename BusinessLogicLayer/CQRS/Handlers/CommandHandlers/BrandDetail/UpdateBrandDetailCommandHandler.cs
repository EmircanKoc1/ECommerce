using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.BrandDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.BrandDetail;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.BrandDetail
{
    public class UpdateBrandDetailCommandHandler : IRequestHandler<UpdateBrandDetailCommandRequest, (UpdateBrandDetailCommandResponse, UpdateBrandDetailCommandResponse)>
    {
        IMapper _mapper;
        IBrandDetailService _brandDetailService;
        IValidator<BrandDetailDto> _validator;

        public UpdateBrandDetailCommandHandler(IMapper mapper, IBrandDetailService brandDetailService, IValidator<BrandDetailDto> validator)
        {
            _mapper = mapper;
            _brandDetailService = brandDetailService;
            _validator = validator;
        }

        public async Task<(UpdateBrandDetailCommandResponse, UpdateBrandDetailCommandResponse)> Handle(UpdateBrandDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<BrandDetailDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return ValueTuple.Create<UpdateBrandDetailCommandResponse, UpdateBrandDetailCommandResponse>(null, null);

            var tupleDto = _brandDetailService.Update(dto);

            var old = _mapper.Map<UpdateBrandDetailCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateBrandDetailCommandResponse>(tupleDto.Item2);

            return (old, @new);


        }
    }
}
