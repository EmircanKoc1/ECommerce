using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Address
{
    public class DeleteAddressCommandRequest
    {
        public long Id { get; set; }    
    }
}
