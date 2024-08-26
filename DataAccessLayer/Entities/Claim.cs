using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Claim : BaseEntity
    {
        public Claim() => Users = new HashSet<User>();

        public string ClaimType { get; set; }
        public string ClaimName { get; set; }


        public ICollection<User> Users { get; set; }

    }
}
