using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IOrderItemService : IBaseReadService<OrderItemDto, OrderItem>, IBaseWriteService<OrderItemDto, OrderItem>
    {
    }
}
