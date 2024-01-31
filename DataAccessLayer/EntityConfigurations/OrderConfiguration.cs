using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.User)
            //    .WithMany(x => x.Orders)
            //    .HasForeignKey(x => x.UserId);


            //builder
            //    .HasOne(x => x.OrderStatus)
            //    .WithOne(x => x.Order)
            //    .HasForeignKey<OrderStatus>(x => x.OrderId);

            //builder
            //    .HasOne(x => x.Address)
            //    .WithMany(x => x.Orders)
            //    .HasForeignKey(x => x.AddressId);

            //builder
            //    .HasMany(x => x.OrderItems)
            //    .WithOne(x => x.Order)
            //    .HasForeignKey(x => x.OrderId);

            //builder
            //    .HasOne(x => x.Coupon)
            //    .WithMany(x => x.Orders)
            //    .HasForeignKey(x => x.CouponId);

            //builder
            //    .HasOne(x => x.ShipmentCompany)
            //    .WithMany(x => x.Orders)
            //    .HasForeignKey(x => x.ShipmentCompanyId);





        }
    }
}
