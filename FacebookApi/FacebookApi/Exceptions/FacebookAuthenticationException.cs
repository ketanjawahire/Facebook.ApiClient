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
    [Serializable]
    public class FacebookAuthenticationException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookAuthenticationException"/>
        /// </summary>
        public FacebookAuthenticationException() : base()
        {
            
        }
    }
}
