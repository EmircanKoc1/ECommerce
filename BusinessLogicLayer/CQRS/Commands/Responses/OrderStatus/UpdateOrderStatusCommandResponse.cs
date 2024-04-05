using BusinessLogicLayer.CQRS.Commands.Responses.Base;
using CoreLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Responses.OrderStatus
{
    public class UpdateOrderStatusCommandResponse  :BaseOrderStatusCommandResponse
    {
        public long? OrderId { get; set; }
        public string Description { get; set; }
        public bool IsPreparing { get; set; }
        public bool IsCancel { get; set; }
        public bool IsFinal { get; set; }
        public bool IsShipment { get; set; }
    }
}
