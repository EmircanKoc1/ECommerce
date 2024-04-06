using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompanyDetail;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ShipmentCompanyDetail
{
    internal class CreateShipmentCompanyDetailCommandHandler : IRequestHandler<CreateShipmentCompanyDetailCommandRequest, CreateShipmentCompanyDetailCommandResponse>
    {
        IMapper _mapper;
        IShipmentCompanyDetailService _shipmentCompanyDetailService;
        IValidator<ShipmentCompanyDetailDto> _validator;

        public CreateShipmentCompanyDetailCommandHandler(IMapper mapper, IShipmentCompanyDetailService shipmentCompanyDetailService, IValidator<ShipmentCompanyDetailDto> validator)
        {
            _mapper = mapper;
            _shipmentCompanyDetailService = shipmentCompanyDetailService;
            _validator = validator;
        }

        public async Task<CreateShipmentCompanyDetailCommandResponse> Handle(CreateShipmentCompanyDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ShipmentCompanyDetailDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (validationResult.IsValid)
                return null;

            var responseDto = _shipmentCompanyDetailService.AddAsync(dto);

            return _mapper.Map<CreateShipmentCompanyDetailCommandResponse>(responseDto);

        }
    }
}
