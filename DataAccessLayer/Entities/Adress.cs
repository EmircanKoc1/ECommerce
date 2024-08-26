using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Address : BaseEntity
    {

        public Address() => Orders = new HashSet<Order>();

        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string AdressDescription { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
