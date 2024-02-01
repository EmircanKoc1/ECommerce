using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            #region Relation
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.Category)
            //    .WithMany(x => x.Products)
            //    .HasForeignKey(x => x.CategoryId);

            //builder
            //    .HasOne(x => x.SubCategory)
            //    .WithMany(x => x.Products)
            //    .HasForeignKey(x => x.SubCategoryId);

            //builder
            //    .HasOne(x => x.Brand)
            //    .WithMany(x => x.Products)
            //    .HasForeignKey(x => x.BrandId);

            //builder
            //    .HasMany(x => x.OrderItems)
            //    .WithOne(x => x.Product)
            //    .HasForeignKey(x => x.ProductId);
            #endregion

            builder
                .ToTable("Products");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
                .Property(x => x.CategoryId)
                .IsRequired(false)
                .HasColumnName("CategoryId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);

            builder
               .Property(x => x.SubCategoryId)
               .IsRequired(false)
               .HasColumnName("SubCategoryId")
               .HasColumnType("bigint")
               .HasColumnOrder(3);

            builder
             .Property(x => x.BrandId)
             .IsRequired(false)
             .HasColumnName("BrandId")
             .HasColumnType("bigint")
             .HasColumnOrder(4);

            builder
                .Property(x => x.Name)
                .IsRequired(true)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .HasColumnOrder(5);

            builder
               .Property(x => x.Description)
               .IsRequired(true)
               .HasColumnName("Description")
               .HasColumnType("nvarchar")
               .HasMaxLength(100)
               .HasColumnOrder(6);

            builder
                .Property(x => x.Price)
                .IsRequired(true)
                .HasColumnName("Price")
                .HasColumnType("float")
                .HasColumnOrder(7);

            builder
              .Property(x => x.StockQuantity)
              .IsRequired(true)
              .HasColumnName("StockQuantity")
              .HasColumnType("int")
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
