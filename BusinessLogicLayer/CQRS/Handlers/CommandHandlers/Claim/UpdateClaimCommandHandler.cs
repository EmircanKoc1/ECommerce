using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Claim;
using BusinessLogicLayer.CQRS.Commands.Responses.Claim;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Claim
{
    public class UpdateClaimCommandHandler : IRequestHandler<UpdateClaimCommandRequest, (UpdateClaimCommandResponse, UpdateClaimCommandResponse)>
    {
        IMapper _mapper;
        IValidator<ClaimDto> _validator;
        IClaimService _claimService;

        public UpdateClaimCommandHandler(IMapper mapper, IValidator<ClaimDto> validator, IClaimService claimService)
        {
            _mapper = mapper;
            _validator = validator;
            _claimService = claimService;
        }

        public async Task<(UpdateClaimCommandResponse, UpdateClaimCommandResponse)> Handle(UpdateClaimCommandRequest request, CancellationToken cancellationToken)
        {
            var claimDto = _mapper.Map<ClaimDto>(request);
            var validationResult = await _validator.ValidateAsync(claimDto);

            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _claimService.Update(claimDto);

            var old = _mapper.Map<UpdateClaimCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateClaimCommandResponse>(tupleDto.Item2);


            return (old, @new);
        }
    }
}
