using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ShipmentCompanyDetailConfiguration : IEntityTypeConfiguration<ShipmentCompanyDetail>
    {
        public void Configure(EntityTypeBuilder<ShipmentCompanyDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}
