using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class BrandDetail : BaseEntity
    {
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public DateTime FoundedYear { get; set; }

        public long BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}
