using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Claim
{
    public record ClaimForUpdateDto : BaseDtoForUpdate
    {
        public string ClaimType { get; init; }
        public string ClaimName { get; init; }
    }
}
