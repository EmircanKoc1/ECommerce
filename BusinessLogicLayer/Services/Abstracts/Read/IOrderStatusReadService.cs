using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.OrderStatus;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IOrderStatusReadService : IReadService<OrderStatusForReadDto,OrderStatus>
    {
    }
}
