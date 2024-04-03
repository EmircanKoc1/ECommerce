using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Address
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, CreateAddressCommandResponse>
    {
        IMapper _mapper;
        IAddressService _addressService;
        IValidator<AddressDto> _validator;

        public CreateAddressCommandHandler(IMapper mapper, IAddressService addressService, IValidator<AddressDto> validator)
        {
            _mapper = mapper;
            _addressService = addressService;
            _validator = validator;
        }

        public async Task<CreateAddressCommandResponse> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var addressDto = _mapper.Map<AddressDto>(request);
            var validationResult = _validator.Validate(addressDto);

            if (!validationResult.IsValid)
                return new CreateAddressCommandResponse();

            var servicesResponse = await _addressService.AddAsync(addressDto);
            
            var commandResponseModel = _mapper.Map<CreateAddressCommandResponse>(servicesResponse);

            return commandResponseModel;




        }
    }
}
