using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Tag : BaseEntity
    {
        public Tag() => Products = new HashSet<Product>();
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
