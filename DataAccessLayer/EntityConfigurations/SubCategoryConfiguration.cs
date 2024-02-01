using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {

            builder
                .ToTable("SubCategories");

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
                .Property(x => x.Name)
                .IsRequired(true)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .HasColumnOrder(3);

            builder
               .Property(x => x.Description)
               .IsRequired(true)
               .HasColumnName("Description")
               .HasColumnType("nvarchar")
               .HasMaxLength(200)
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
