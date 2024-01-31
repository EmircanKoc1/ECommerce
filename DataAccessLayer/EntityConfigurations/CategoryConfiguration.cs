using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasMany(x => x.SubCategories)
            //    .WithOne(x => x.Category)
            //    .HasForeignKey(x => x.CategoryId);


        }
    }
}
