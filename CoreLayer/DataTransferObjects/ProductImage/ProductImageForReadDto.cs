using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.ProductImage
{
    public record ProductImageForReadDto : BaseDtoForRead
    {
        public string ImagePath { get; init; }
        public long? ProductId { get; init; }
    }
}
