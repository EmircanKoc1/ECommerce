using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Address
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommandRequest, DeleteAddressCommandResponse>
    {
        IMapper _mapper;
        IAddressService _addressService;

        public DeleteAddressCommandHandler(IMapper mapper, IAddressService addressService)
        {
            _mapper = mapper;
            _addressService = addressService;
        }

        public Task<DeleteAddressCommandResponse> Handle(DeleteAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var address = _mapper.Map<AddressDto>(request);
            var response = _addressService.Delete(address);

            return Task.FromResult(_mapper.Map<DeleteAddressCommandResponse>(response));


        }
    }
}
