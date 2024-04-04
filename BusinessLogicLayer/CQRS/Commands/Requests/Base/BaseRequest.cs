using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Base;

public abstract class BaseRequest
{
    public long Id { get; set; }
}
