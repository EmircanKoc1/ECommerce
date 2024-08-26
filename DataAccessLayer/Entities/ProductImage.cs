using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class ProductImage : BaseEntity
    {
        public string ImagePath { get; set; }
        public long? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
