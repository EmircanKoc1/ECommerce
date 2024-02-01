using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ClaimConfiguration : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> builder)
        {
            #region Relations
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasMany(x => x.Users)
            //    .WithMany(x => x.Claims);

            #endregion

            builder
                .ToTable("Claims");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
                .Property(x => x.ClaimType)
                .IsRequired(true)
                .HasColumnName("ClaimType")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasColumnOrder(2);


            builder
                .Property(x => x.ClaimName)
                .IsRequired(true)
                .HasColumnName("ClaimName")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
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
