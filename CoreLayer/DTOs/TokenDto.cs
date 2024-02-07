namespace CoreLayer.DTOs
{
    public class TokenDto : BaseDto
    {
        public string TokenType { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? TokenExpireDate { get; set; }

        public long? UserId { get; set; }
        public UserDto User { get; set; }

    }
}
