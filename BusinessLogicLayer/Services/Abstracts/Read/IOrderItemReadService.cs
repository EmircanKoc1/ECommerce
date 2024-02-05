using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.OrderItem;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IOrderItemReadService : IReadService<OrderItemForReadDto,OrderItem>
    {
    }
}
