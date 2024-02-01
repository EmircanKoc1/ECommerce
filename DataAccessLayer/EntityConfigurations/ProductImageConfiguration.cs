using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder
                .ToTable("ProductImages");

            builder
                .Property(x => x.Id)
                .IsRequired(false)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
              .Property(x => x.ProductId)
              .IsRequired(false)
              .HasColumnName("ProductId")
              .HasColumnType("bigint")
              .HasColumnOrder(2);

            builder
                .Property(x => x.ImagePath)
                .IsRequired(true)
                .HasColumnName("ImagePath")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .HasColumnOrder(3);

            builder
                .Property(x => x.CreatedDate)
                .IsRequired(true)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime2")
                .HasColumnOrder(9);

            builder
             .Property(x => x.UpdatedDate)
             .IsRequired(true)
             .HasColumnName("UpdatedDate")
             .HasColumnType("datetime2")
             .HasColumnOrder(10);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(true)
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
