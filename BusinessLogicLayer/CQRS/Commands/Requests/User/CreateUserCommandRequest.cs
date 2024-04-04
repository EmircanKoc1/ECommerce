using BusinessLogicLayer.CQRS.Commands.Responses.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.User
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Password { get; set; }
   
    }
}
