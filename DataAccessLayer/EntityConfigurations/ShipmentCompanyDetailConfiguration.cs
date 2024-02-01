using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ShipmentCompanyDetailConfiguration : IEntityTypeConfiguration<ShipmentCompanyDetail>
    {
        public void Configure(EntityTypeBuilder<ShipmentCompanyDetail> builder)
        {
            builder
               .ToTable("ShipmentCompanyDetails");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
               .Property(x => x.ShipmentCompanyId)
               .IsRequired(false)
               .HasColumnName("ShipmentCompanyId")
               .HasColumnType("bigint")
               .HasColumnOrder(2);

            builder
                .Property(x => x.TotalShipmentCount)
                .IsRequired(true)
                .HasColumnName("TotalShipmentCount")
                .HasColumnType("int")
                .HasColumnOrder(3);

            builder
               .Property(x => x.TotalFailedShipmentCount)
               .IsRequired(true)
               .HasColumnName("TotalFailedShipmentCount")
               .HasColumnType("int")
               .HasColumnOrder(4);

            builder
               .Property(x => x.TotalSuccessfulShipmentCount)
               .IsRequired(true)
               .HasColumnName("TotalSuccessfulShipmentCount")
               .HasColumnType("int")
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
