namespace CoreLayer.DTOs
{
    public class OrderItemDto : BaseDto
    {
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }

        public long? OrderId { get; set; }
        public OrderDto Order { get; set; }

        public long? ProductId { get; set; }
        public ProductDto Product { get; set; }
    }
}
