using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder
                .ToTable("ProductFeatures");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
                .Property(x => x.ProductId)
                .IsRequired(true)
                .HasColumnName("ProductId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);

            builder
                .Property(x => x.Key)
                .IsRequired(true)
                .HasColumnName("Key")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .HasColumnOrder(3);

            builder
              .Property(x => x.Value)
              .IsRequired(true)
              .HasColumnName("Value")
              .HasColumnType("nvarchar")
              .HasMaxLength(100)
              .HasColumnOrder(4);

            builder
           .Property(x => x.CreatedDate)
           .IsRequired(false)
           .HasColumnName("CreatedDate")
           .HasColumnType("datetime2")
           .HasColumnOrder(5);

            builder
             .Property(x => x.UpdatedDate)
             .IsRequired(false)
             .HasColumnName("UpdatedDate")
             .HasColumnType("datetime2")
             .HasColumnOrder(6);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(false)
               .HasColumnName("DeletedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(7);

            builder
                .Property(x => x.Status)
                .IsRequired(true)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .HasColumnOrder(8);



        }
    }
}
