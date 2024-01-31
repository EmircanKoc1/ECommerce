using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
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

        }
    }
}
