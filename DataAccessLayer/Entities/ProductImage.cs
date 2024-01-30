using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class ProductImage : ModifiableBaseEntity
    {
        public string ImagePath { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
