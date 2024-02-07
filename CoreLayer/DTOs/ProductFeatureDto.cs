namespace CoreLayer.DTOs
{
    public class ProductFeatureDto : BaseDto
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public long? ProductId { get; set; }
        public ProductDto Product { get; set; }
    }
}
