using BusinessLogicLayer.CQRS.Commands.Responses.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Category
{
    public class UpdateCategoryCommandRequest : IRequest<(UpdateCategoryCommandResponse, UpdateCategoryCommandResponse)>
    {
    }
}
