using System;
using System.Runtime.Serialization;

namespace UnityHelpers
{
    public class GameObjectNullException : Exception
    {
        public GameObjectNullException()
        {
        }

        public GameObjectNullException(string message) 
            : base(message)
        {
        }

        public GameObjectNullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected GameObjectNullException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}
