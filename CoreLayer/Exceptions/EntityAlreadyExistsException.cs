using System.Runtime.Serialization;

namespace CoreLayer.Exceptions
{
    public class EntityAlreadyExistsException : Exception
    {
        public EntityAlreadyExistsException(string message) : base(message)
        {

        }
        public EntityAlreadyExistsException(string message, Exception exception) : base(message, exception)
        {

        }

        public EntityAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

    }
}
