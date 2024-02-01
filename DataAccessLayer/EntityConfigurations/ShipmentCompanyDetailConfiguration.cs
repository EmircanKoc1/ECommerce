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
                .IsRequired(false)
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
              .IsRequired(true)
              .HasColumnName("CreatedDate")
              .HasColumnType("datetime2")
              .HasColumnOrder(9);

            builder
             .Property(x => x.UpdatedDate)
             .IsRequired(true)
             .HasColumnName("UpdatedDate")
             .HasColumnType("datetime2")
             .HasColumnOrder(10);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(true)
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
