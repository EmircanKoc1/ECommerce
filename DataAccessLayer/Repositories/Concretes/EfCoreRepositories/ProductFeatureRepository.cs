using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class ProductFeatureRepository : GenericRepository<ProductFeature>, IProductFeatureRepository
    {
        public ProductFeatureRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
