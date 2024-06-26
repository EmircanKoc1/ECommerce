﻿using BusinessLogicLayer.CQRS.Commands.Responses.OrderItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.OrderItem
{
    public class DeleteOrderItemCommandRequest : IRequest<DeleteOrderItemCommandResponse>
    {
    }
}
