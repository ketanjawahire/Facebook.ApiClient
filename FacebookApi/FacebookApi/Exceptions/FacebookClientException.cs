using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
