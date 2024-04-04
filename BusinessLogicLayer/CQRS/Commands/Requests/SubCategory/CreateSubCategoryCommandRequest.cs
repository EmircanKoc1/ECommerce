using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.SubCategory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.SubCategory
{
    public class CreateSubCategoryCommandRequest : IRequest<CreateSubCategoryCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? CategoryId { get; set; }

    }
}
