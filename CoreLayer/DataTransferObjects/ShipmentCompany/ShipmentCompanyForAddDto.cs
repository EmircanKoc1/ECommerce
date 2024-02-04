﻿using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.ShipmentCompany
{
    public record ShipmentCompanyForAddDto : BaseDtoForAdd
    {
        public string Name { get; init; }

    }
}
