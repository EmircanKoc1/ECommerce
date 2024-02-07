namespace CoreLayer.DTOs
{
    public class ProductImageDto : BaseDto
    {
        public string ImagePath { get; set; }
        public long? ProductId { get; set; }
        public ProductDto Product { get; set; }

    }
}
