using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Claim
{
    public record ClaimForAddDto : BaseDtoForAdd
    {
        public string ClaimType { get; init; }
        public string ClaimName { get; init; }


    }
}
