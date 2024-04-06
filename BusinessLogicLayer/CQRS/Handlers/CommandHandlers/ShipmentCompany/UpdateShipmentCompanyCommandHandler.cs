using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ShipmentCompany
{
    public class UpdateShipmentCompanyCommandHandler : IRequestHandler<UpdateShipmentCompanyCommandRequest, (UpdateShipmentCompanyCommandResponse, UpdateShipmentCompanyCommandResponse)>
    {
        IMapper _mapper;
        IShipmentCompanyService _shipmentCompanyService;
        IValidator<ShipmentCompanyDto> _validator;

        public UpdateShipmentCompanyCommandHandler(IMapper mapper, IShipmentCompanyService shipmentCompanyService, IValidator<ShipmentCompanyDto> validator)
        {
            _mapper = mapper;
            _shipmentCompanyService = shipmentCompanyService;
            _validator = validator;
        }

        public async Task<(UpdateShipmentCompanyCommandResponse, UpdateShipmentCompanyCommandResponse)> Handle(UpdateShipmentCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ShipmentCompanyDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (validationResult.IsValid)
                return (null, null);

            var tupleDto = _shipmentCompanyService.Update(dto);
            var old = _mapper.Map<UpdateShipmentCompanyCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateShipmentCompanyCommandResponse>(tupleDto.Item2);

            return (old, @new);


        }
    }
}
