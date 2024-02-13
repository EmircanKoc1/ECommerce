using System.Xml.Linq;

namespace CoreLayer.DTOs
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int StockQuantity { get; set; }


        public long? CategoryId { get; set; }
        public CategoryDto Category { get; set; }


        public long? SubCategoryId { get; set; }
        public SubCategoryDto SubCategory { get; set; }


        public long? BrandId { get; set; }
        public BrandDto Brand { get; set; }


        public ICollection<OrderItemDto> OrderItems { get; set; }
        public ICollection<UserDto> LikedUsers { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
        public ICollection<ProductFeatureDto> Features { get; set; }
        public ICollection<ProductImageDto> Images { get; set; }
        public ICollection<TagDto> Tags { get; set; }



    }
}
