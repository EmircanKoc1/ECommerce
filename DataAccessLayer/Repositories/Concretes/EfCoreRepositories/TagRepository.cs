using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
