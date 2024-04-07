using BusinessLogicLayer.CQRS.Queries.Responses.Order;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Order
{
    public class OrderGetByIdRequest : IRequest<OrderGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
