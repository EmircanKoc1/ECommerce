namespace CoreLayer.DTOs
{
    public class BrandDto : BaseDto
    {
        public string Name { get; set; }

        public BrandDetailDto BrandDetail { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}
