using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.Base;

namespace DataAccessLayer.Repositories.Concretes.EfCoreRepositories
{
    public class ShipmentCompanyDetailRepository : GenericRepository<ShipmentCompanyDetail>, IShipmentCompanyDetailRepository
    {
        public ShipmentCompanyDetailRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
   







}
