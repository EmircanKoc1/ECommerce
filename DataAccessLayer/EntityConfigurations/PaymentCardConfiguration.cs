using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class PaymentCardConfiguration : IEntityTypeConfiguration<PaymentCard>
    {
        public void Configure(EntityTypeBuilder<PaymentCard> builder)
        {

            #region Relation
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.User)
            //    .WithMany(x => x.PaymentCard)
            //    .HasForeignKey(x => x.UserId);
            #endregion

            builder
                .ToTable("PaymentCards");

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
                .Property(x => x.Company)
                .IsRequired(false)
                .HasColumnName("Company")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .HasColumnOrder(3);

            builder
                .Property(x => x.Number)
                .IsRequired(false)
                .HasColumnName("Number")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .HasColumnOrder(4);

            builder
              .Property(x => x.PersonName)
              .IsRequired(false)
              .HasColumnName("PersonName")
              .HasColumnType("nvarchar")
              .HasMaxLength(50)
              .HasColumnOrder(5);

            builder
              .Property(x => x.PersonSurname)
              .IsRequired(false)
              .HasColumnName("PersonSurname")
              .HasColumnType("nvarchar")
              .HasMaxLength(50)
              .HasColumnOrder(6);

            builder
             .Property(x => x.ExpireDate)
             .IsRequired(false)
             .HasColumnName("ExpireDate")
             .HasColumnType("datetime2")
             .HasColumnOrder(7);

            builder
            .Property(x => x.CCV)
            .IsRequired(false)
            .HasColumnName("CCV")
            .HasColumnType("datetime2")
            .HasColumnOrder(8);

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
