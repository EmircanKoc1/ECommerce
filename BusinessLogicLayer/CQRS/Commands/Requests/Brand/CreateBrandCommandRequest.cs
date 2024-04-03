using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.Brand;
using CoreLayer.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Brand
{
    public class CreateBrandCommandRequest : IRequest<CreateBrandCommandResponse>
    {
        public string Name { get; set; }
       
    }
}
