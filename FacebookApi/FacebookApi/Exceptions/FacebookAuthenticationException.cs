using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns an authentication error.
    /// </summary>
    public class FacebookAuthenticationException : Exception
    {
        public FacebookAuthenticationException() : base()
        {
            
        }
    }
}
