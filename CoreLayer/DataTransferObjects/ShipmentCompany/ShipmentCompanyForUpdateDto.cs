﻿using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.ShipmentCompany
{
    public record ShipmentCompanyForUpdateDto : BaseDtoForUpdate
    {
        public string Name { get; init; }
    }
}