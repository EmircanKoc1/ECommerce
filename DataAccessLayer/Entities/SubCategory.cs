using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class SubCategory : BaseEntity
    {

        public SubCategory() => Products = new HashSet<Product>();
        public string Name { get; set; }
        public string Description { get; set; }
        public long? CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
