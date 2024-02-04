using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.ProductFeature
{
    public record ProductFeatureForAddDto : BaseDtoForAdd
    {
        public string Key { get; init; }
        public string Value { get; init; }
        public long? ProductId { get; init; }
    }
}
