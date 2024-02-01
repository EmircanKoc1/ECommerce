using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            #region Relation
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
            #endregion

            builder
                .ToTable("Orders");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);


            builder
                .Property(x => x.UserId)
                .IsRequired(false)
                .HasColumnName("UserId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);


            builder
                .Property(x => x.AddressId)
                .IsRequired(false)
                .HasColumnName("AddressId")
                .HasColumnType("bigint")
                .HasColumnOrder(3);

            builder
                .Property(x => x.CouponId)
                .IsRequired(false)
                .HasColumnName("CouponId")
                .HasColumnType("bigint")
                .HasColumnOrder(4);


            builder
                .Property(x => x.ShipmentCompanyId)
                .IsRequired(false)
                .HasColumnName("ShipmentCompanyId")
                .HasColumnType("bigint")
                .HasColumnOrder(5);

            builder
                .Property(x => x.OrderDate)
                .IsRequired(true)
                .HasColumnName("OrderDate")
                .HasColumnType("datetime2")
                .HasColumnOrder(6);

            builder
                .Property(x => x.TotalAmount)
                .IsRequired(true)
                .HasDefaultValue(0)
                .HasColumnName("TotalAmount")
                .HasColumnType("float")
                .HasColumnOrder(7);

            builder
                .Property(x => x.DiscountAmount)
                .IsRequired(true)
                .HasDefaultValue(0)
                .HasColumnName("DiscountAmount")
                .HasColumnType("float")
                .HasColumnOrder(8);

            builder
               .Property(x => x.CreatedDate)
               .IsRequired(false)
               .HasColumnName("CreatedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(9);

            builder
               .Property(x => x.UpdatedDate)
               .IsRequired(false)
               .HasColumnName("UpdatedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(10);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(false)
               .HasColumnName("DeletedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(11);

            builder
                .Property(x => x.Status)
                .IsRequired(true)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .HasColumnOrder(12);


        }
    }
}
