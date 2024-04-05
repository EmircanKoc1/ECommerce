namespace CoreLayer.DTOs
{
    public class OrderStatusDto : BaseDto
    {
        public long? OrderId { get; set; }
        public OrderDto Order { get; set; }
        public string Description { get; set; }
        public bool IsPreparing { get; set; }
        public bool IsCancel { get; set; }
        public bool IsFinal { get; set; }
        public bool IsShipment { get; set; }

    }
}
