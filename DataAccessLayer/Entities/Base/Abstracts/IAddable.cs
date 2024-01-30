using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Base.Abstracts
{
    public interface IAddable
    {
        public long CreatedById { get; set; }
        public User CreatedByUser { get; set; }

    }
}
