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
    public class FacebookServerException : Exception
    {
        public FacebookServerException() : base()
        {
            
        }
    }
}
