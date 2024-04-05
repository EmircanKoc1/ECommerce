using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Claim;
using BusinessLogicLayer.CQRS.Commands.Responses.Claim;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Claim
{
    public class DeleteClaimCommandHandler : IRequestHandler<DeleteClaimCommandRequest, DeleteClaimCommandResponse>
    {
        IMapper _mapper;
        IClaimService _claimService;

        public DeleteClaimCommandHandler(IMapper mapper, IClaimService claimService)
        {
            _mapper = mapper;
            _claimService = claimService;
        }

        public Task<DeleteClaimCommandResponse> Handle(DeleteClaimCommandRequest request, CancellationToken cancellationToken)
        {
            var claimDto = _mapper.Map<ClaimDto>(request);
            var responseDto = _claimService.Delete(claimDto);


            return Task.FromResult(_mapper.Map<DeleteClaimCommandResponse>(responseDto));
        }
    }
}
