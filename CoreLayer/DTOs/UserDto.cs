using System.Net;
using System.Security.Claims;
using System.Xml.Linq;

namespace CoreLayer.DTOs
{
    public class UserDto : BaseDto
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }
        public TokenDto Token { get; set; }
        public ICollection<PaymentCardDto> PaymentCards { get; set; }
        public ICollection<AddressDto> Address { get; set; }
        public ICollection<ProductDto> LikedProducts { get; set; }
        public ICollection<OrderDto> Orders { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
        public ICollection<ClaimDto> Claims { get; set; }

    }
}
