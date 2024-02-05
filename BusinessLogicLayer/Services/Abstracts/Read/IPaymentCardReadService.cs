using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.PaymentCard;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IPaymentCardReadService : IReadService<PaymentCardForReadDto, PaymentCard>
    {
    }
}
