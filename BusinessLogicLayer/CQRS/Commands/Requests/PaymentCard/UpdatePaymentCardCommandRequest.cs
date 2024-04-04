using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.PaymentCard;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.PaymentCard
{
    public class UpdatePaymentCardCommandRequest :BaseRequest, IRequest<(UpdatePaymentCardCommandResponse, UpdatePaymentCardCommandResponse)>
    {
        public string Company { get; set; }
        public string Number { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string CCV { get; set; }
        public long? UserId { get; set; }

    }
}
