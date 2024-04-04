using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail
{
    public class UpdateShipmentCompanyCommandRequest : BaseRequest,IRequest<(UpdateShipmentCompanyCommandResponse, UpdateShipmentCompanyCommandResponse)>
    {
        public int TotalShipmentCount { get; set; }
        public int TotalFailedShipmentCount { get; set; }
        public int TotalSuccessfulShipmentCount { get; set; }
        public string Description { get; set; }
        public DateTime? FoundedYear { get; set; }
        public long? ShipmentCompanyId { get; set; }

    }
}
