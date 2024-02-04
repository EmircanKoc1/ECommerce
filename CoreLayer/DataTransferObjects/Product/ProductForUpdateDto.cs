using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Product
{
    public record ProductForUpdateDto : BaseDtoForUpdate
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public float Price { get; init; }
        public int StockQuantity { get; init; }
        public long? CategoryId { get; init; }
        public long? SubCategoryId { get; init; }
        public long? BrandId { get; init; }
    }
}
