using BusinessLogicLayer.CQRS.Commands.Responses.BrandDetail;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.BrandDetail
{
    public  class CreateBrandDetailCommandRequest : IRequest<CreateBrandDetailCommandResponse>
    {
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public DateTime? FoundedYear { get; set; }
        public long? BrandId { get; set; }

    }
}
