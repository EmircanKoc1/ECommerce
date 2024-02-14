using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class ClaimRepository : GenericRepository<Claim>, IClaimRepository
    {
        public ClaimRepository(ECommerceDbContext context) : base(context)
        {
        }

        public IEnumerable<Claim> GetUserClaims(User user)
        {
            return _context.Users
                .Where(x => x.Id == user.Id)
                .Include(x => x.Claims)
                .SelectMany(x => x.Claims)
                .AsEnumerable();

        }

       
    }








}
