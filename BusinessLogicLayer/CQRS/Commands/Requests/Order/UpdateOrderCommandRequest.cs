using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Order;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Order;

public class UpdateOrderCommandRequest : BaseRequest, IRequest<(UpdateOrderCommandResponse, UpdateOrderCommandResponse)>
{
    public DateTime OrderDate { get; set; }
    public float TotalAmount { get; set; }
    public float DiscountAmount { get; set; }
    public float FinalAmount { get; set; }
    public long? UserId { get; set; }
    public long? AddressId { get; set; }
    public AddressModel Address { get; set; }
    public ICollection<OrderItemModel> OrderItems { get; set; }
    public long? CouponId { get; set; }
    public long? ShipmentCompanyId { get; set; }


    public class AddressModel
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string AdressDescription { get; set; }
    }
    public class OrderItemModel
    {
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }
        public long? OrderId { get; set; }
        public long? ProductId { get; set; }
    }
}

