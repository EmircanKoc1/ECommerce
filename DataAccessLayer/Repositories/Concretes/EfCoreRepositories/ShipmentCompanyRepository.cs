using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class ShipmentCompanyRepository : GenericRepository<ShipmentCompany>, IShipmentCompanyRepository
    {
        public ShipmentCompanyRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
