using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DTOs
{
    public class AddressDto : BaseDto
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string AdressDescription { get; set; }
        public long? UserId { get; set; }
        public UserDto User { get; set; }
        public ICollection<OrderDto> Orders { get; set; }
    }
}
