namespace BusinessLogicLayer.CQRS.Commands.Responses.Base
{
    public abstract class BaseUserCommandResponse : BaseCommandResponse
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
