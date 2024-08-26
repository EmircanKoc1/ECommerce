using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Comment : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public int Score { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
