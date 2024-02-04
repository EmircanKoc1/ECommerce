﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.Address
{
    public record AddressForReadDto
    {
        public string City { get; init; }
        public string Street { get; init; }
        public string Zipcode { get; init; }
        public string AdressDescription { get; init; }
        public long? UserId { get; init; }

    }
    public record AddressForReadWithIdDto
    {
        public long AddressId { get; set; }
        public string City { get; init; }
        public string Street { get; init; }
        public string Zipcode { get; init; }
        public string AdressDescription { get; init; }
        public long? UserId { get; init; }

    }
}