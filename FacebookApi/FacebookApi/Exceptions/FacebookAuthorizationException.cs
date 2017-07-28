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
    [Serializable]
    public class FacebookAuthorizationException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthorizationException"/>
        /// </summary>
        public FacebookAuthorizationException() : base()
        {
            
        }
    }
}
