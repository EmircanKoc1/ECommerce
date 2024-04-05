using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Claim;
using BusinessLogicLayer.CQRS.Commands.Responses.Claim;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Claim
{
    public class CreateClaimCommandHandler : IRequestHandler<CreateClaimCommandRequest, CreateClaimCommandResponse>
    {
        IMapper _mapper;
        IValidator<ClaimDto> _validator;
        IClaimService _claimService;

        public CreateClaimCommandHandler(IMapper mapper, IValidator<ClaimDto> validator, IClaimService claimService)
        {
            _mapper = mapper;
            _validator = validator;
            _claimService = claimService;
        }

        public async Task<CreateClaimCommandResponse> Handle(CreateClaimCommandRequest request, CancellationToken cancellationToken)
        {
            var claimDto = _mapper.Map<ClaimDto>(request);
            var validationResult = await _validator.ValidateAsync(claimDto);

            if (!validationResult.IsValid)
                return null;

            var responseDto = _claimService.AddAsync(claimDto);

            return _mapper.Map<CreateClaimCommandResponse>(responseDto);


        }
    }
}
