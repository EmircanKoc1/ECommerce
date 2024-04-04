using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.BrandDetail
{
    public class DeleteBrandDetailCommandRequest : IRequest<DeleteBrandDetailCommandRequest>
    {
        public long Id { get; set; }
    }
}
