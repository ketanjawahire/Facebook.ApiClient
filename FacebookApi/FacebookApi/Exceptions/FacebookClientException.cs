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
    public class FacebookClientException : Exception
    {
        public FacebookClientException() : base()
        {
            
        }
    }
}
