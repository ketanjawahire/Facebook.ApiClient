using System;
using System.Runtime.Serialization;

namespace Facebook.ApiClient.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns an authentication error.
    /// </summary>
    [Serializable]
    public class FacebookAuthenticationException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthenticationException"/>
        /// </summary>
        public FacebookAuthenticationException() : base()
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthenticationException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        public FacebookAuthenticationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthenticationException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner excecption</param>
        public FacebookAuthenticationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthenticationException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected FacebookAuthenticationException(SerializationInfo info, StreamingContext context) : base(info,
            context)
        {
        }
    }
}
