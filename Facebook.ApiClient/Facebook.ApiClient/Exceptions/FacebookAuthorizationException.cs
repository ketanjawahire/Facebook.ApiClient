using System;
using System.Runtime.Serialization;

namespace Facebook.ApiClient.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns a user permissions error.
    /// </summary>
    [Serializable]
    public class FacebookAuthorizationException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthorizationException"/>
        /// </summary>
        public FacebookAuthorizationException() : base()
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthorizationException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        public FacebookAuthorizationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthorizationException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public FacebookAuthorizationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthorizationException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected FacebookAuthorizationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
