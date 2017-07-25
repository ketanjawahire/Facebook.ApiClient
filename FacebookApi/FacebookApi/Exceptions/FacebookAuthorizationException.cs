using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns a user permissions error.
    /// </summary>
    public class FacebookAuthorizationException : Exception
    {
        public FacebookAuthorizationException() : base()
        {
            
        }
    }
}
