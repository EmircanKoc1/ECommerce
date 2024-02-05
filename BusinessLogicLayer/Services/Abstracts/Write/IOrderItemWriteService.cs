using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.OrderItem;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IOrderItemWriteService : IWriteService<OrderItemForUpdateDto, OrderItemForDeleteDto, OrderItemForAddDto, OrderItem>
    {
    }

}
