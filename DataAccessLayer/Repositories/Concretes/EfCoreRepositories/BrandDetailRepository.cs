using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class BrandDetailRepository : GenericRepository<BrandDetail>, IBrandDetailRepository
    {
        public BrandDetailRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
