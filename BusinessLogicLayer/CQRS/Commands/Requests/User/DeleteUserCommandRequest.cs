using BusinessLogicLayer.CQRS.Commands.Responses.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.User
{
    public class DeleteUserCommandRequest : IRequest<DeleteUserCommandResponse>
    {
    }
}
