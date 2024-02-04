using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.ProductImage
{
    public record ProductImageForUpdateDto : BaseDtoForUpdate
    {
        public string ImagePath { get; init; }
        public long? ProductId { get; init; }

    }
}
