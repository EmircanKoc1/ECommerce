using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.PaymentCard;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.PaymentCard
{
    public class DeletePaymentCardCommandRequest : BaseRequest,IRequest<DeletePaymentCardCommandResponse>
    {
    }
}
