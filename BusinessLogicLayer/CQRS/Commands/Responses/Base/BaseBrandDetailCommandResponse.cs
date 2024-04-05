using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Responses.Base
{
    public abstract class BaseBrandDetailCommandResponse : BaseCommandResponse
    {
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public DateTime? FoundedYear { get; set; }
        public long? BrandId { get; set; }
    }
}
