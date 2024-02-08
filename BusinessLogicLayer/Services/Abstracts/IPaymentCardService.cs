using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IPaymentCardService : IBaseReadService<PaymentCardDto, PaymentCard>, IBaseWriteService<PaymentCardDto, PaymentCard>
    {
    }
}
