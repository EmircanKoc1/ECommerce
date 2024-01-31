using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Claim : BaseEntity
    {
        public string ClaimType { get; set; }
        public string ClaimName { get; set; }


        public ICollection<User> Users { get; set; }

    }
}
