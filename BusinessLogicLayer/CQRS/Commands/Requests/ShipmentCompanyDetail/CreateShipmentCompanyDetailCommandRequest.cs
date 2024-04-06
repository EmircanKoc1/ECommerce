using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompanyDetail;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail
{
    public class CreateShipmentCompanyDetailCommandRequest : BaseRequest,IRequest<CreateShipmentCompanyDetailCommandResponse>
    {
        public int TotalShipmentCount { get; set; }
        public int TotalFailedShipmentCount { get; set; }
        public int TotalSuccessfulShipmentCount { get; set; }

        public string Description { get; set; }
        public DateTime? FoundedYear { get; set; }

        public long? ShipmentCompanyId { get; set; }
    }
}
