using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IOrderService : IBaseReadService<OrderDto, Order>, IBaseWriteService<OrderDto, Order>
    {
    }
}
