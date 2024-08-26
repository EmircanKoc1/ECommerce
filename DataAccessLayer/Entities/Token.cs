using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Token : BaseEntity
    {
        public string TokenType { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? TokenExpireDate { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

    }


}
