using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Brand : BaseEntity
    {

        public Brand() => Products = new HashSet<Product>();

        public string Name { get; set; }

        public BrandDetail BrandDetail { get; set; }
        public ICollection<Product> Products { get; set; }



    }
}
