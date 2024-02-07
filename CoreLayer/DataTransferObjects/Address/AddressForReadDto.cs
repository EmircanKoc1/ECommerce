using CoreLayer.DataTransferObjects.Base;
using CoreLayer.DataTransferObjects.Order;
using CoreLayer.DataTransferObjects.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.Address
{
    public record AddressForReadDto : BaseDtoForRead
    {
        public string City { get; init; }
        public string Street { get; init; }
        public string Zipcode { get; init; }
        public string AdressDescription { get; init; }
        public long? UserId { get; init; }
        public UserForReadDto UserForReadDto { get; init; }
        public ICollection<OrderForReadDto> Orders { get; init; }

    }
    
}
