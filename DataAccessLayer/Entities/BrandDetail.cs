using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class BrandDetail : BaseEntity
    {
       
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public DateTime? FoundedYear { get; set; }
        public Guid? BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}
