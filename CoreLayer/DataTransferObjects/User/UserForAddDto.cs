using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.User
{
    public record UserForAddDto : BaseDtoForAdd
    {
        public string Username { get; init; }
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
        public string Password { get; init; }

    }
   

}
