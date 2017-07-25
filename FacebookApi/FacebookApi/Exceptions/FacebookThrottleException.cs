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
    public class FacebookThrottleException : Exception
    {
        public FacebookThrottleException() : base()
        {
            
        }
    }
}
