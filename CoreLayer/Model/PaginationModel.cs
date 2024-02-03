namespace CoreLayer.Model
{
    public class PaginationModel
    {
        public int PageSize
        {
            get => pageSize;
            set => pageSize = value >= maxPageSize ? maxPageSize : (value <= 0 ? 1 : value);
        }
        public int PageNumber
        {
            get => pageNumber;
            set => pageNumber = value <= 0 ? 1 : value;
        }

        private const int maxPageSize = 100;
        private int pageSize = 1;
        private int pageNumber = 1;
    }
}
