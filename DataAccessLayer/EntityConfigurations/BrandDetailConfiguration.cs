using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class BrandDetailConfiguration : IEntityTypeConfiguration<BrandDetail>
    {
        public void Configure(EntityTypeBuilder<BrandDetail> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Brand)
                .WithOne(x => x.BrandDetail)
                .HasForeignKey<BrandDetail>(x => x.BrandId);


        }
    }
}
