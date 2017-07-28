using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Exceptions
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
    }
}
