using BusinessLogicLayer.CQRS.Queries.Responses.OrderStatus;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.OrderStatus
{
    public class OrderStatusGetByIdRequest : IRequest<OrderStatusGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
