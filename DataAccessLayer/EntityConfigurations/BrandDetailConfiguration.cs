using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class BrandDetailConfiguration : IEntityTypeConfiguration<BrandDetail>
    {
        public void Configure(EntityTypeBuilder<BrandDetail> builder)
        {
            #region Relations
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.Brand)
            //    .WithOne(x => x.BrandDetail)
            //    .HasForeignKey<BrandDetail>(x => x.BrandId);
            #endregion

            builder
                .ToTable("BrandDetails");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
                .Property(x => x.BrandId)
                .IsRequired(false)
                .HasColumnName("BrandId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);

            builder
                .Property(x => x.Description)
                .IsRequired(false)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .HasColumnOrder(3);

            builder
                .Property(x => x.LogoPath)
                .IsRequired(false)
                .HasColumnName("LogoPath")
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .HasColumnOrder(4);

            builder
                .Property(x => x.FoundedYear)
                .IsRequired(false)
                .HasColumnName("FoundedYear")
                .HasColumnType("datetime2")
                .HasColumnOrder(5);

            builder
                .Property(x => x.CreatedDate)
                .IsRequired(false)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime2")
                .HasColumnOrder(6);

            builder
               .Property(x => x.UpdatedDate)
               .IsRequired(false)
               .HasColumnName("UpdatedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(7);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(false)
               .HasColumnName("DeletedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(8);

            builder
                .Property(x => x.Status)
                .IsRequired(true)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .HasColumnOrder(9);


        }
    }
}
