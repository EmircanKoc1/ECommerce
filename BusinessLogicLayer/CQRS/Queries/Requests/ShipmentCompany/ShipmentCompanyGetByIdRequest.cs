using BusinessLogicLayer.CQRS.Queries.Responses.ShipmentCompany;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.ShipmentCompany
{
    public class ShipmentCompanyGetByIdRequest : IRequest<ShipmentCompanyGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
