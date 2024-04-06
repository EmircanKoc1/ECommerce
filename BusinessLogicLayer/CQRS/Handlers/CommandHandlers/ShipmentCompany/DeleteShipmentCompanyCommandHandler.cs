using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ShipmentCompany
{
    public class DeleteShipmentCompanyCommandHandler : IRequestHandler<DeleteShipmentCompanyCommandRequest, DeleteShipmentCompanyCommandResponse>
    {
        IMapper _mapper;
        IShipmentCompanyService _shipmentCompanyServie;

        public DeleteShipmentCompanyCommandHandler(IMapper mapper, IShipmentCompanyService shipmentCompanyServie)
        {
            _mapper = mapper;
            _shipmentCompanyServie = shipmentCompanyServie;
        }

        public Task<DeleteShipmentCompanyCommandResponse> Handle(DeleteShipmentCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ShipmentCompanyDto>(request);

            var responseDto = _shipmentCompanyServie.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteShipmentCompanyCommandResponse>(responseDto));

        }
    }
}
