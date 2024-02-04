using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.SubCategory
{
    public record SubCategoryForAddDto : BaseDtoForAdd
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public long? CategoryId { get; init; }

    }

}
