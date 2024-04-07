using BusinessLogicLayer.CQRS.Queries.Responses.Address;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Address
{
    public class AddressGetByIdRequest : IRequest<AddressGetByIdResponse>
    {
        public long Id { get; set; }
    }
  
}
