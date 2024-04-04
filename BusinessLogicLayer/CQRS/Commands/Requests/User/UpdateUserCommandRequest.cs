using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.User;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.User
{
    public class UpdateUserCommandRequest : BaseRequest, IRequest<(UpdateUserCommandResponse, UpdateUserCommandResponse)>
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }

    }
}
