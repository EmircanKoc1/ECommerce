using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.OrderItem
{
    public record OrderItemForAddDto : BaseDtoForAdd
    {
        public int Quantity { get; init; }
        public float Price { get; init; }
        public float TotalPrice { get; init; }
        public long? OrderId { get; init; }
        public long? ProductId { get; init; }
    }
}
