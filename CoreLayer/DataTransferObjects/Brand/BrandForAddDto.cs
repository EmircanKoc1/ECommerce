using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Brand
{
    public record BrandForAddDto : BaseDtoForAdd
    {
        public string Name { get; init; }

    }
}
