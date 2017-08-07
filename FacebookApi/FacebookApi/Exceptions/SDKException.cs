using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Exceptions
{
    /// <summary>
    /// Represents error in SDK while deserializing api responce
    /// </summary>
    [Serializable]
    [SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly")]
    public class SDKException : Exception
    {
        /// <summary>
        /// Content of api responce as string
        /// </summary>
        public string ApiResponseContent { get; private set; }

        /// <summary>
        /// Initialize new instance of <see cref="SDKException"/>
        /// </summary>
        /// <param name="apiResponseContent">Content of api responce as string</param>
        /// <param name="ex">Exception</param>
        public SDKException(string apiResponseContent, Exception ex) : base(ex.Message, ex)
        {
            ApiResponseContent = apiResponseContent;
        }
    }
}
