using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.Order)
            //    .WithOne(x => x.OrderStatus)
            //    .HasForeignKey<OrderStatus>(x => x.OrderId);





        }
    }
}
