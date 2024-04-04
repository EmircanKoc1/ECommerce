using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail
{
    public class CreateShipmentCompanyCommandRequest : IRequest<CreateShipmentCompanyCommandResponse>
    {
        public int TotalShipmentCount { get; set; }
        public int TotalFailedShipmentCount { get; set; }
        public int TotalSuccessfulShipmentCount { get; set; }
        public string Description { get; set; }
        public DateTime? FoundedYear { get; set; }
        public long? ShipmentCompanyId { get; set; }

    }
}
