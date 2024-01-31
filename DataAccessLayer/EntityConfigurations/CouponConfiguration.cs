using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            #region Relations
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasMany(x => x.Orders)
            //    .WithOne(x => x.Coupon)
            //    .HasForeignKey(x => x.CouponId);

            #endregion

            builder
                .ToTable("Coupons");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
                .Property(x => x.Name)
                .IsRequired(true)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .HasColumnOrder(2);

            builder
               .Property(x => x.Description)
               .IsRequired(true)
               .HasColumnName("Description")
               .HasColumnType("nvarchar")
               .HasMaxLength(150)
               .HasColumnOrder(3);

            builder
               .Property(x => x.Code)
               .IsRequired(true)
               .HasColumnName("Code")
               .HasColumnType("nvarchar")
               .HasMaxLength(30)
               .HasColumnOrder(4);

            builder
                .Property(x => x.MinimumPrice)
                .IsRequired(true)
                .HasDefaultValue(0)
                .HasColumnName("MinimumPrice")
                .HasColumnType("float")
                .HasColumnOrder(5);

            builder
              .Property(x => x.DiscountAmount)
              .IsRequired(true)
              .HasDefaultValue(0)
              .HasColumnName("DiscountAmount")
              .HasColumnType("float")
              .HasColumnOrder(6);

            builder
            .Property(x => x.CreatedDate)
            .IsRequired(true)
            .HasColumnName("CreatedDate")
            .HasColumnType("datetime2")
            .HasColumnOrder(7);

            builder
               .Property(x => x.UpdatedDate)
               .IsRequired(true)
               .HasColumnName("UpdatedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(8);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(true)
               .HasColumnName("DeletedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(9);

            builder
                .Property(x => x.Status)
                .IsRequired(true)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .HasColumnOrder(10);
        }
    }
}
