using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.PaymentCard;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IPaymentCardWriteService : IWriteService<PaymentCardForUpdateDto, PaymentCardForDeleteDto, PaymentCardForAddDto, PaymentCard>
    {
    }

}
