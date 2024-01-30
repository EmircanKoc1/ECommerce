using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Category : ModifiableBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }

    }
}
