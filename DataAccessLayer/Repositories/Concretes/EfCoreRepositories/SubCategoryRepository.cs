using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
