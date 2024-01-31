using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityDatabaseConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.User)
            //    .WithMany(x => x.Address)
            //    .HasForeignKey(x => x.UserId);

            //builder
            //    .HasMany(x => x.Orders)
            //    .WithOne(x => x.Address)
            //    .HasForeignKey(x => x.AddressId);


        }
    }
}
