using BusinessLogicLayer.CQRS.Commands.Responses.PaymentCard;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.PaymentCard
{
    public class DeletePaymentCardCommandRequest : IRequest<DeletePaymentCardCommandResponse>
    {
    }
}
