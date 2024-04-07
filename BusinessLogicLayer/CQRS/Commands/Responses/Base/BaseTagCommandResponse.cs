using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Responses.Base
{
    public class BaseTagCommandResponse:BaseCommandResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
