using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.BrandDetail
{
    public record BrandDetailForAddDto : BaseDtoForAdd
    {
        public string Description { get; init; }
        public string LogoPath { get; init; }
        public DateTime? FoundedYear { get; init; }
        public long? BrandId { get; init; }


    }
}
