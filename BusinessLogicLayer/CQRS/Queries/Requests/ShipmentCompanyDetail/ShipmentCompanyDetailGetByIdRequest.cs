using BusinessLogicLayer.CQRS.Queries.Responses.ShipmentCompanyDetail;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.ShipmentCompanyDetail
{
    public class ShipmentCompanyDetailGetByIdRequest : IRequest<ShipmentCompanyDetailGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
