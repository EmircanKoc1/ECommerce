using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
