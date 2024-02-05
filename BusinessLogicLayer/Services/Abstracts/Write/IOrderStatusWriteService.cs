using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.OrderStatus;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IOrderStatusWriteService : IWriteService<OrderStatusForUpdateDto, OrderStatusForDeleteDto, OrderStatusForAddDto, OrderStatus>
    {
    }

}
