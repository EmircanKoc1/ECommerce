using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Category
{
    public class UpdateCategoryCommandRequest : BaseRequest, IRequest<(UpdateCategoryCommandResponse, UpdateCategoryCommandResponse)>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
