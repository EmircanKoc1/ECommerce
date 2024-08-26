using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
            LikedUsers = new HashSet<User>();
            Comments = new HashSet<Comment>();
            Features = new HashSet<ProductFeature>();
            Images = new HashSet<ProductImage>();
            Tags = new HashSet<Tag>();

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int StockQuantity { get; set; }


        public long? CategoryId { get; set; }
        public Category Category { get; set; }


        public long? SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }


        public long? BrandId { get; set; }
        public Brand Brand { get; set; }


        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<User> LikedUsers { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ProductFeature> Features { get; set; }
        public ICollection<ProductImage> Images { get; set; }

        public ICollection<Tag> Tags { get; set; }

    }
}
