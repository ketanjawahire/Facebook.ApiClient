using System;
using System.Runtime.Serialization;

namespace Facebook.ApiClient.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns a throttle error.
    /// </summary>
    [Serializable]
    public class FacebookThrottleException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookThrottleException"/>
        /// </summary>
        public FacebookThrottleException() : base()
        {
            
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookThrottleException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        public FacebookThrottleException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookThrottleException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public FacebookThrottleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookThrottleException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected FacebookThrottleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
