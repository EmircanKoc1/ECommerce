using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Responses.Address
{
    public class UpdateAddressCommandResponse 
    {
        public long Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string AdressDescription { get; set; }
        public long? UserId { get; set; }


    }


}
