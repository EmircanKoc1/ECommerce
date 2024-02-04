using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.SubCategory
{
    public record SubCategoryForUpdateDto : BaseDtoForUpdate
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public long? CategoryId { get; init; }
    }
}
