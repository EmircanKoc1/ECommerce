using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            PaymentCards = new HashSet<PaymentCard>();
            Address = new HashSet<Address>();
            LikedProducts = new HashSet<Product>();
            Orders = new HashSet<Order>();
            Comments = new HashSet<Comment>();
            Claims = new HashSet<Claim>();

        }


        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }

        public Token Token { get; set; }


        public ICollection<PaymentCard> PaymentCards { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Product> LikedProducts { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Claim> Claims { get; set; }




    }
}
