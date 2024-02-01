using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            #region Relations
            //builder
            //    .HasKey(e => e.Id);

            //builder
            //    .HasOne(x => x.Order)
            //    .WithMany(x => x.OrderItems)
            //    .HasForeignKey(x => x.OrderId);

            //builder
            //    .HasOne(x => x.Product)
            //    .WithMany(x => x.OrderItems)
            //    .HasForeignKey(x => x.ProductId);
            #endregion

            builder
                .ToTable("OrderItems");

            builder
                .Property(e => e.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
                .Property(e => e.OrderId)
                .IsRequired(false)
                .HasColumnName("OrderId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);


            builder
                .Property(e => e.ProductId)
                .IsRequired(false)
                .HasColumnName("ProductId")
                .HasColumnType("bigint")
                .HasColumnOrder(3);

            builder
                .Property(x => x.Quantity)
                .IsRequired(true)
                .HasColumnName("Quantity")
                .HasColumnType("int")
                .HasColumnOrder(4);

            builder
               .Property(x => x.Price)
               .IsRequired(true)
               .HasColumnName("Price")
               .HasColumnType("float")
               .HasColumnOrder(5);


            builder
               .Property(x => x.TotalPrice)
               .IsRequired(true)
               .HasColumnName("TotalPrice")
               .HasColumnType("float")
               .HasColumnOrder(5);

            builder
            .Property(x => x.CreatedDate)
            .IsRequired(true)
            .HasColumnName("CreatedDate")
            .HasColumnType("datetime2")
            .HasColumnOrder(6);

            builder
               .Property(x => x.UpdatedDate)
               .IsRequired(true)
               .HasColumnName("UpdatedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(7);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(true)
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
