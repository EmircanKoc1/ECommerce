using BusinessLogicLayer.CQRS.Queries.Responses.PaymentCard;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.PaymentCard
{
    public class PaymentCardGetByIdRequest : IRequest<PaymentCardGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
