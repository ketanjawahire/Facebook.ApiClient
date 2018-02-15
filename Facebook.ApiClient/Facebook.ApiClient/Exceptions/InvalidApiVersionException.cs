using System;
using System.Runtime.Serialization;

namespace Facebook.ApiClient.Exceptions
{
    /// <summary>
    /// Represents Invalid Api Version Exception
    /// </summary>
    [Serializable]
    public class InvalidApiVersionException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="InvalidApiVersionException"/>
        /// </summary>
        public InvalidApiVersionException() : base("Invalid Facebook API version specified.")
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="InvalidApiVersionException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        public InvalidApiVersionException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="InvalidApiVersionException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public InvalidApiVersionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="InvalidApiVersionException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected InvalidApiVersionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
