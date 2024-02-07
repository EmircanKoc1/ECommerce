namespace CoreLayer.DTOs
{
    public class CategoryDto : BaseDto
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<SubCategoryDto> SubCategories { get; set; }
        public ICollection<ProductDto> Products { get; set; }


    }
}
