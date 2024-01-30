using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class ProductFeature : ModifiableBaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }


    }
}
