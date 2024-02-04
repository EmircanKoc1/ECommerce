using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.OrderStatus
{
    public record OrderStatusForAddDto : BaseDtoForAdd
    {
        public long? OrderId { get; init; }
        public string Description { get; init; }
        public bool IsPreparing { get; init; }
        //public bool IsCancel { get; set; }
        //public bool IsFinal { get; set; }
        //public bool IsShipment { get; set; }

    }

}
