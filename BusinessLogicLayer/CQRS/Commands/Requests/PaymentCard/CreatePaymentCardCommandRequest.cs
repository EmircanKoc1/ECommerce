using BusinessLogicLayer.CQRS.Commands.Responses.PaymentCard;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.PaymentCard
{
    public class CreatePaymentCardCommandRequest : IRequest<CreatePaymentCardCommandResponse>
    {
    }
}
