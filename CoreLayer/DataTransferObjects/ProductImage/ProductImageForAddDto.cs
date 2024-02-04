using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.ProductImage
{
    public record ProductImageForAddDto : BaseDtoForAdd
    {
        public string ImagePath { get; init; }
        public long? ProductId { get; init; }

    }
}
