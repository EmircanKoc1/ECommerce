using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ClaimConfiguration : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> builder)
        {
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasMany(x => x.Users)
            //    .WithMany(x => x.Claims);


        }
    }
}
