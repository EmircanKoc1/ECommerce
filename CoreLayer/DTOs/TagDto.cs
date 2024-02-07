namespace CoreLayer.DTOs
{
    public class TagDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ProductDto> Products { get; set; }
    }
}
