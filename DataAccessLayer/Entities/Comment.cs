using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Comment : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public short Score { get; set; }

        public long? ProductId { get; set; }
        public Product Product { get; set; }

        public long? UserId { get; set; }
        public User User { get; set; }

    }
}
