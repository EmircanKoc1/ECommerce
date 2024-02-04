using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.OrderItem
{
    public record OrderItemForUpdateDto : BaseDtoForUpdate
    {
        public int Quantity { get; init; }
        public float Price { get; init; }
        public float TotalPrice { get; init; }
        public long? OrderId { get; init; }
        public long? ProductId { get; init; }
    }
}
