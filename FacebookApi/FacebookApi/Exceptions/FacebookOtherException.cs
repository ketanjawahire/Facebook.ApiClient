using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Exceptions
{
    /// <summary>
    /// Thrown when Graph returns an error that is unknown to the SDK.
    /// </summary>
    public class FacebookOtherException : Exception
    {
        public FacebookOtherException() : base()
        {
            
        }
    }
}
