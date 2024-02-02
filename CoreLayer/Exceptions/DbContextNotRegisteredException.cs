using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Exceptions
{

    public class DbContextNotRegisteredException : Exception
    {
        public DbContextNotRegisteredException()
        {
        }

        public DbContextNotRegisteredException(string? message) : base(message)
        {
        }

        protected DbContextNotRegisteredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
