using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompanyDetail;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail
{
    public class DeleteShipmentCompanyCommandRequest : BaseRequest,IRequest<DeleteShipmentCompanyCommandResponse>
    {

    }
}
