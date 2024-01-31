using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityDatabaseConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            #region Relation
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.User)
            //    .WithMany(x => x.Address)
            //    .HasForeignKey(x => x.UserId);

            //builder
            //    .HasMany(x => x.Orders)
            //    .WithOne(x => x.Address)
            //    .HasForeignKey(x => x.AddressId);
            #endregion

            builder
                .ToTable("Address");

            builder
                .Property(x => x.City)
                .IsRequired(false)
                .HasColumnName("City")
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .HasColumnOrder(1);

            builder
                .Property(x => x.Street)
                .IsRequired(false)
                .HasColumnName("Street")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .HasColumnOrder(3);

            builder
                .Property(x => x.Zipcode)
                .IsRequired(false)
                .HasColumnName("Zipcode")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasColumnOrder(4);

            builder
                .Property(x => x.AdressDescription)
                .IsRequired(false)
                .HasColumnName("AddressDescription")
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .HasColumnOrder(5);

            builder
                .Property(x=>x.UserId)
                .IsRequired(false)
                .HasColumnName("UserId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);
                

        }
    }
}
