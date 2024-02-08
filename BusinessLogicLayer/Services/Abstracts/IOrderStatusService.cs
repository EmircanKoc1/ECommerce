using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IOrderStatusService : IBaseReadService<OrderStatusDto, OrderStatus>, IBaseWriteService<OrderStatusDto, OrderStatus>
    {
    }
}
