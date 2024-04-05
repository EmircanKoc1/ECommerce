﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Responses.Base
{
    public abstract class BaseClaimCommandResponse : BaseCommandResponse
    {
        public string ClaimType { get; set; }
        public string ClaimName { get; set; }

    }
}
