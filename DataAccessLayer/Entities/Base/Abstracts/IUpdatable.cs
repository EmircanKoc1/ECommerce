namespace DataAccessLayer.Entities.Base.Abstracts
{
    public interface IUpdatable
    {
        public long UpdatedById { get; set; }
        public User UpdatedByUser { get; set; }


    }
}
