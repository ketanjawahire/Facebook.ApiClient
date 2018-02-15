using System;
using System.Runtime.Serialization;

namespace Facebook.ApiClient.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns a server error.
    /// </summary>
    [Serializable]
    public class FacebookServerException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookServerException"/>
        /// </summary>
        public FacebookServerException() : base()
        {
            
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookServerException"/>
        /// </summary>
        /// <param name="message">Excecption message</param>
        public FacebookServerException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookServerException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner excecption</param>
        public FacebookServerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookServerException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected FacebookServerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
