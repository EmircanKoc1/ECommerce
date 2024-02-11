using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Exceptions
{
    public class ParameterValueNullException : Exception
    {
        public ParameterValueNullException(string message) : base (message)
        {
            
        }
    }
}
