using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Product
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
    }
}
