using BusinessLogicLayer.CQRS.Queries.Responses.OrderItem;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.OrderItem
{
    public class OrderItemGetByIdRequest : IRequest<OrderItemGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
