using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Facebook.ApiClient.Exceptions
{
    /// <summary>
    /// Represents error in SDK while deserializing api responce
    /// </summary>
    [Serializable]
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

        /// <summary>
        /// Initialize new instance of <see cref="SDKException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected SDKException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Populates a SerializationInfo with the data needed to serialize the target object.
        /// </summary>
        /// <param name="info">The SerializationInfo to populate with data.</param>
        /// <param name="context">The destination for this serialization.</param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));

            info.AddValue("ApiResponseContent", ApiResponseContent);

            base.GetObjectData(info, context);
        }
    }
}
