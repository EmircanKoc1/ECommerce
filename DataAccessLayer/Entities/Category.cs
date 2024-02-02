using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
            SubCategories = new HashSet<SubCategory>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
