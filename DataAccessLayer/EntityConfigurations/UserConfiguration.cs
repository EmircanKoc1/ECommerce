using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Users");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
               .Property(x => x.Username)
               .IsRequired(true)
               .HasColumnName("Username")
               .HasColumnType("nvarchar")
               .HasMaxLength(50)
               .HasColumnOrder(2);

            builder
               .Property(x => x.Name)
               .IsRequired(true)
               .HasColumnName("Name")
               .HasColumnType("nvarchar")
               .HasMaxLength(50)
               .HasColumnOrder(3);


            builder
               .Property(x => x.Surname)
               .IsRequired(false)
               .HasColumnName("Surname")
               .HasColumnType("nvarchar")
               .HasMaxLength(50)
               .HasColumnOrder(4);

            builder
               .Property(x => x.Email)
               .IsRequired(false)
               .HasColumnName("Email")
               .HasColumnType("nvarchar")
               .HasMaxLength(50)
               .HasColumnOrder(5);

            builder
               .Property(x => x.PhoneNumber)
               .IsRequired(false)
               .HasColumnName("PhoneNumber")
               .HasColumnType("nvarchar")
               .HasMaxLength(20)
               .HasColumnOrder(6);

            builder
                .Property(x => x.BirthDate)
                .IsRequired(false)
                .HasColumnName("BirthDate")
                .HasColumnType("datetime2")
                .HasColumnOrder(7);


            builder
                .Property(x => x.Password)
                .IsRequired(false)
                .HasColumnName("Password")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .HasColumnOrder(8);

            builder
                .Property(x => x.EmailConfirmed)
                .IsRequired(true)
                .HasDefaultValue(0)
                .HasColumnName("EmailConfirmed")
                .HasColumnType("bit")
                .HasColumnOrder(9);


            builder
                .Property(x => x.CreatedDate)
                .IsRequired(false)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime2")
                .HasColumnOrder(10);

            builder
               .Property(x => x.UpdatedDate)
               .IsRequired(false)
               .HasColumnName("UpdatedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(11);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(false)
               .HasColumnName("DeletedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(12);

            builder
                .Property(x => x.Status)
                .IsRequired(true)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .HasColumnOrder(13);



        }
    }
}
