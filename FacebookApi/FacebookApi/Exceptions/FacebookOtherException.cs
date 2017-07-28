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
    [Serializable]
    public class FacebookOtherException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="FacebookOtherException"/>
        /// </summary>
        public FacebookOtherException() : base()
        {
            
        }
    }
}
