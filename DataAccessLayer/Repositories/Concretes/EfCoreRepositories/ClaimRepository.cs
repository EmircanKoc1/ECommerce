using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class ClaimRepository : GenericRepository<Claim>, IClaimRepository
    {
        public ClaimRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
