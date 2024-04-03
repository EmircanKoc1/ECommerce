using BusinessLogicLayer.CQRS.Commands.Responses.Tag;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Tag
{
    public class DeleteTagCommandRequest : IRequest<DeleteTagCommandResponse>
    {
    }
}
