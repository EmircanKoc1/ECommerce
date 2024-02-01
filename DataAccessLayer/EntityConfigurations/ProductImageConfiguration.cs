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
                .IsRequired(true)
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
                .IsRequired(false)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime2")
                .HasColumnOrder(4);

            builder
             .Property(x => x.UpdatedDate)
             .IsRequired(false)
             .HasColumnName("UpdatedDate")
             .HasColumnType("datetime2")
             .HasColumnOrder(5);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(false)
               .HasColumnName("DeletedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(6);

            builder
                .Property(x => x.Status)
                .IsRequired(true)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .HasColumnOrder(7);


        }
    }
}
