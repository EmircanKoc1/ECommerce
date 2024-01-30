using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Base.Abstracts
{
    public interface IDeletable
    {
        public long DeletedById { get; set; }
        public User DeletedByUser { get; set; }
    }
}
