using CoreLayer.DTOs;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts.Base;

namespace DataAccessLayer.Repositories.Abstracts
{
    public interface IClaimRepository : IGenericRepository<Claim>
    {
        IEnumerable<Claim> GetUserClaims(User user);
        //Task<IEnumerable<Claim>> GetUserClaimsAsync(User user);
    }
}
