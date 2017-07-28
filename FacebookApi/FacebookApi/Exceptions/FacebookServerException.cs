using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns a server error.
    /// </summary>
    [Serializable]
    public class FacebookServerException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookServerException"/>
        /// </summary>
        public FacebookServerException() : base()
        {
            
        }
    }
}
