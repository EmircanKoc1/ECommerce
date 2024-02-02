using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class TokenRepository : GenericRepository<Token>, ITokenRepository
    {
        public TokenRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
