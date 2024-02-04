using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Brand
{
    public record BrandForUpdateDto : BaseDtoForUpdate
    {
        public string Name { get; init; }

    }
}
