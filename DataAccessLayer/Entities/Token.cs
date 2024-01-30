using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Token : ModifiableBaseEntity
    {
        public string TokenType { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string TokenExpireDate { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

    }


}
