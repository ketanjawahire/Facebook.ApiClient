using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns a duplicate post error.
    /// </summary>
    [Serializable]
    public class FacebookClientException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookClientException"/>
        /// </summary>
        public FacebookClientException() : base()
        {
            
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookClientException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        public FacebookClientException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookClientException"/>
        /// </summary>
        /// <param name="message">Excecption message</param>
        /// <param name="innerException">Inner exception</param>
        public FacebookClientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookClientException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected FacebookClientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
