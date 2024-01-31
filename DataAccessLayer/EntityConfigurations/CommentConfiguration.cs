using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            #region Relations
            //builder
            //    .HasKey(x => x.Id);

            //builder
            //    .HasOne(x => x.User)
            //    .WithMany(x => x.Comments)
            //    .HasForeignKey(x => x.UserId);

            //builder
            //    .HasOne(x => x.Product)
            //    .WithMany(x => x.Comments)
            //    .HasForeignKey(x => x.ProductId);
            #endregion

            builder
                .ToTable("Id");

            builder
                .Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .HasColumnOrder(1);

            builder
                .Property(x => x.ProductId)
                .IsRequired(false)
                .HasColumnName("ProductId")
                .HasColumnType("bigint")
                .HasColumnOrder(2);

            builder
               .Property(x => x.UserId)
               .IsRequired(false)
               .HasColumnName("UserId")
               .HasColumnType("bigint")
               .HasColumnOrder(3);

            builder
                .Property(x => x.Title)
                .IsRequired(true)
                .HasColumnName("Title")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .HasColumnOrder(4);

            builder
               .Property(x => x.Text)
               .IsRequired(true)
               .HasColumnName("Text")
               .HasColumnType("nvarchar")
               .HasMaxLength(300)
               .HasColumnOrder(5);

            builder
            .Property(x => x.Score)
            .IsRequired(true)
            .HasColumnName("Score")
            .HasColumnType("tinyint")
            .HasColumnOrder(6);


            builder
             .Property(x => x.CreatedDate)
             .IsRequired(true)
             .HasColumnName("CreatedDate")
             .HasColumnType("datetime2")
             .HasColumnOrder(7);

            builder
               .Property(x => x.UpdatedDate)
               .IsRequired(true)
               .HasColumnName("UpdatedDate")
               .HasColumnType("datetime2")
               .HasColumnOrder(8);

            builder
               .Property(x => x.DeletedDate)
               .IsRequired(true)
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
