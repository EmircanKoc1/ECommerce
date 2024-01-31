using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Answer : BaseEntity
    {
        public string Content { get; set; }
        public DateTime DataAsked { get; set; }

        public long? UserId { get; set; }
        public User User { get; set; }

        public long? ProductId { get; set; }
        public Product Product { get; set; }

        public bool IsAnswered { get; set; }
        public bool IsRead { get; set; }

    }
}
