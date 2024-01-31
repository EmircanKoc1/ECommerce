using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasMany(x => x.Orders)
            //    .WithOne(x => x.Coupon)
            //    .HasForeignKey(x => x.CouponId);



        }
    }
}
