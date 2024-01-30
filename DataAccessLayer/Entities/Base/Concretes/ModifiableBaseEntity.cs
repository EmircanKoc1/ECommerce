using DataAccessLayer.Entities.Base.Abstracts;

namespace DataAccessLayer.Entities.Base.Concretes
{
    public class ModifiableBaseEntity : BaseEntity, IAddable, IDeletable, IUpdatable
    {
        public long UpdatedById { get; set; }
        public User UpdatedByUser { get; set; }
        public long DeletedById { get; set; }
        public User DeletedByUser { get; set; }
        public long CreatedById { get; set; }
        public User CreatedByUser { get; set; }
    }
}
