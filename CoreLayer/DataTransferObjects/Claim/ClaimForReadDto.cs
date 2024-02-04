using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Claim
{
    public record ClaimForReadDto : BaseDtoForRead
    {
        public string ClaimType { get; init; }
        public string ClaimName { get; init; }
    }
}
