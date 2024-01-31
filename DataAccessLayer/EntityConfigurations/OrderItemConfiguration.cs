using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {

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

        }
    }
}
