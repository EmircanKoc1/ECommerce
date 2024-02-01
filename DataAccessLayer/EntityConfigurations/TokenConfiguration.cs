using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class TokenConfiguration : IEntityTypeConfiguration<Token>
    {
        public void Configure(EntityTypeBuilder<Token> builder)
        {
            builder
                .ToTable("Tokens");

            builder
              .Property(x => x.Id)
              .IsRequired(true)
              .HasColumnName("Id")
              .HasColumnType("bigint")
              .HasColumnOrder(1);

            builder
             .Property(x => x.UserId)
             .IsRequired(true)
             .HasColumnName("UserId")
             .HasColumnType("bigint")
             .HasColumnOrder(2);

            builder
              .Property(x => x.TokenType)
              .IsRequired(true)
              .HasColumnName("TokenType")
              .HasColumnType("nvarchar")
              .HasMaxLength(100)
              .HasColumnOrder(3);

            builder
              .Property(x => x.AccessToken)
              .IsRequired(false)
              .HasColumnName("AccessToken")
              .HasColumnType("nvarchar")
              .HasMaxLength(400)
              .HasColumnOrder(4);

            builder
            .Property(x => x.RefreshToken)
            .IsRequired(false)
            .HasColumnName("RefreshToken")
            .HasColumnType("nvarchar")
            .HasMaxLength(100)
            .HasColumnOrder(4);

            builder
              .Property(x => x.TokenExpireDate)
              .IsRequired(true)
              .HasColumnName("TokenExpireDate")
              .HasColumnType("datetime2")
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
