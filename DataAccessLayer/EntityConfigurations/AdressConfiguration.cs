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
                .ToTable("Addresses");

            builder
               .Property(x => x.Id)
               .IsRequired(true)
               .HasColumnName("Id")
               .HasColumnType("bigint")
               .HasColumnOrder(1);

            builder
                .Property(x => x.UserId)
                .IsRequired(false)
                .HasColumnName("UserId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);

            builder
                .Property(x => x.City)
                .IsRequired(false)
                .HasColumnName("City")
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .HasColumnOrder(3);

            builder
                .Property(x => x.Street)
                .IsRequired(false)
                .HasColumnName("Street")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .HasColumnOrder(4);

            builder
                .Property(x => x.Zipcode)
                .IsRequired(false)
                .HasColumnName("Zipcode")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasColumnOrder(5);

            builder
                .Property(x => x.AdressDescription)
                .IsRequired(false)
                .HasColumnName("AddressDescription")
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
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
