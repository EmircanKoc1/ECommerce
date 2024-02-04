using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Brand
{
    public record BrandForReadDto : BaseDtoForRead
    {
        public string Name { get; init; }
    }
}
