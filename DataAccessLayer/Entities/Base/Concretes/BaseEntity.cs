namespace DataAccessLayer.Entities.Base.Concretes
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Status { get; set; }


    }
}
