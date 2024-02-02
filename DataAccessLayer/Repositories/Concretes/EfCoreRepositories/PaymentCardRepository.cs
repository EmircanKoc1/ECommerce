using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class PaymentCardRepository : GenericRepository<PaymentCard>, IPaymentCardRepository
    {
        public PaymentCardRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
