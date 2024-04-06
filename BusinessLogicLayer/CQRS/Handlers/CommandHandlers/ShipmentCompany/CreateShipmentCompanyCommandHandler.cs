using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ShipmentCompany
{
    public class CreateShipmentCompanyCommandHandler : IRequestHandler<CreateShipmentCompanyCommandRequest, CreateShipmentCompanyCommandResponse>
    {
        IMapper _mapper;
        IShipmentCompanyService _shipmentCompanyService;
        IValidator<ShipmentCompanyDto> _validator;

        public CreateShipmentCompanyCommandHandler(IMapper mapper, IShipmentCompanyService shipmentCompanyService, IValidator<ShipmentCompanyDto> validator)
        {
            _mapper = mapper;
            _shipmentCompanyService = shipmentCompanyService;
            _validator = validator;
        }

        public async Task<CreateShipmentCompanyCommandResponse> Handle(CreateShipmentCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ShipmentCompanyDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;

            var responseDto = _shipmentCompanyService.AddAsync(dto);

            return _mapper.Map<CreateShipmentCompanyCommandResponse>(responseDto);
        }
    }
}
