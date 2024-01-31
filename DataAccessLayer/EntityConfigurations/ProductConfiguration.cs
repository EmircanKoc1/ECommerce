using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
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

        }
    }
}
