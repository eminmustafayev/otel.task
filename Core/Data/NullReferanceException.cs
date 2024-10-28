using System.Runtime.Serialization;

namespace Core.Data
{
    [Serializable]
    internal class NullReferanceException : Exception
    {
        public NullReferanceException()
        {
        }

        public NullReferanceException(string? message) : base(message)
        {
        }

        public NullReferanceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NullReferanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}