namespace CoreLayer.DTOs
{
    public class SubCategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public ICollection<ProductDto> Products { get; set; }

    }
}
