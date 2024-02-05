using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Order;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IOrderWriteService : IWriteService<OrderForUpdateDto, OrderForDeleteDto, OrderForAddDto, Order>
    {
    }

}
