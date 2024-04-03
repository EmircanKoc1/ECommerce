using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompanyDetail;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail
{
    public class DeleteShipmentCompanyCommandRequest : IRequest<DeleteShipmentCompanyCommandResponse>
    {
    }
}
