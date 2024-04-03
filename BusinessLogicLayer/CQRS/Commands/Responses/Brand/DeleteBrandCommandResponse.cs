using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Responses.Brand
{
    public class DeleteBrandCommandResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
