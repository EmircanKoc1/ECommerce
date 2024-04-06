using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail
{
    public class UpdateShipmentCompanyCommandRequest : BaseRequest,IRequest<(UpdateShipmentCompanyCommandResponse, UpdateShipmentCompanyCommandResponse)>
    {
        public string Name { get; set; }

    }
}
