using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail
{
    public class CreateShipmentCompanyCommandRequest : IRequest<CreateShipmentCompanyCommandResponse>
    {
        public string Name { get; set; }

    }
}
