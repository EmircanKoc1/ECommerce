using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Answers)
                .HasForeignKey(x => x.UserId);

            builder
                .HasOne(x => x.Product)
                .WithMany(x => x.Answers)
                .HasForeignKey(x => x.ProductId);



        }
    }
}
