using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            #region Relation
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.Order)
            //    .WithOne(x => x.OrderStatus)
            //    .HasForeignKey<OrderStatus>(x => x.OrderId);


            #endregion

            builder
                .ToTable("OrderStatuses");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
                .Property(x => x.OrderId)
                .IsRequired(false)
                .HasColumnName("OrderId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);

            builder
                .Property(x => x.Description)
                .IsRequired(false)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .HasColumnOrder(3);

            builder
                .Property(x => x.IsPreparing)
                .IsRequired(true)
                .HasColumnName("IsPreparing")
                .HasColumnType("bit")
                .HasColumnOrder(4);

            builder
               .Property(x => x.IsCancel)
               .IsRequired(true)
               .HasColumnName("IsCancel")
               .HasColumnType("bit")
               .HasColumnOrder(5);

            builder
               .Property(x => x.IsShipment)
               .IsRequired(true)
               .HasColumnName("IsShipment")
               .HasColumnType("bit")
               .HasColumnOrder(6);

            builder
            .Property(x => x.CreatedDate)
            .IsRequired(false)
            .HasColumnName("CreatedDate")
            .HasColumnType("datetime2")
            .HasColumnOrder(7);

            builder
               .Property(x => x.UpdatedDate)
               .IsRequired(false)
               .HasColumnName("UpdatedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(8);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(false)
               .HasColumnName("DeletedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(9);

            builder
                .Property(x => x.Status)
                .IsRequired(true)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .HasColumnOrder(10);



        }
    }
}
