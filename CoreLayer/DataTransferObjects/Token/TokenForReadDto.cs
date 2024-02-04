using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Token
{
    public record TokenForReadDto : BaseDtoForRead
    {
        public string TokenType { get; init; }
        public string AccessToken { get; init; }
        public string RefreshToken { get; init; }
        public DateTime? TokenExpireDate { get; init; }
        public long? UserId { get; init; }
    }
}
