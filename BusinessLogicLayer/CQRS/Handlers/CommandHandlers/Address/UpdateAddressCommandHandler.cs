using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Address
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, (UpdateAddressCommandResponse, UpdateAddressCommandResponse)>
    {
        IMapper _mapper;
        IAddressService _addressService;
        IValidator<AddressDto> _validator;

        public UpdateAddressCommandHandler(IMapper mapper, IAddressService addressService, IValidator<AddressDto> validator)
        {
            _mapper = mapper;
            _addressService = addressService;
            _validator = validator;
        }

        public async Task<(UpdateAddressCommandResponse, UpdateAddressCommandResponse)> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var addressDto = _mapper.Map<AddressDto>(request);
            var result = await _validator.ValidateAsync(addressDto);

            if (!result.IsValid)
                return (null, null);

            var tupleDto = _addressService.Update(addressDto);
            var old = _mapper.Map<UpdateAddressCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateAddressCommandResponse>(tupleDto.Item2);

            return (old, @new);

        }
    }
}
