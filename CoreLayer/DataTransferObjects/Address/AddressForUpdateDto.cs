using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.Address
{
    public record AddressForUpdateDto : BaseDtoForUpdate
    {
        public string City { get; init; }
        public string Street { get; init; }
        public string Zipcode { get; init; }
        public string AddresDescription { get; init; }
     

    }
}
