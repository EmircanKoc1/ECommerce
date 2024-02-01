using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region Relations
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasMany(x => x.SubCategories)
            //    .WithOne(x => x.Category)
            //    .HasForeignKey(x => x.CategoryId);
            #endregion

            builder
                .ToTable("Categories");

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
                .HasColumnOrder(2);

            builder
                .Property(x => x.Description)
                .IsRequired(false)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
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
