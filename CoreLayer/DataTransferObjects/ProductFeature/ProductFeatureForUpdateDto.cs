using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.ProductFeature
{
    public record ProductFeatureForUpdateDto : BaseDtoForUpdate
    {
        public string Key { get; init; }
        public string Value { get; init; }
        public long? ProductId { get; init; }
    }
}
