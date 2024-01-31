using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ShipmentCompanyConfiguration : IEntityTypeConfiguration<ShipmentCompany>
    {
        public void Configure(EntityTypeBuilder<ShipmentCompany> builder)
        {
            throw new NotImplementedException();
        }
    }
}
