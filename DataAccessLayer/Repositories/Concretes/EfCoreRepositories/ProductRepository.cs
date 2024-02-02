using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
