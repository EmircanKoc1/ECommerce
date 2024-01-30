using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Brand : ModifiableBaseEntity
    {
        public string Name { get; set; }

        public long BrandDetailId { get; set; }
        public BrandDetail BrandDetail { get; set; }
        public ICollection<Product> Products { get; set; }



    }
}
