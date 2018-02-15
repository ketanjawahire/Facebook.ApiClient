using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Facebook.ApiClient.Exceptions
{
    /// <summary>
    /// <para>If no subcode is present, this means that the login status or access token has expired, been revoked, or is otherwise invalid. </para>
    /// <para>Get a new access token. If a subcode is present, see the subcode.</para>
    /// </summary>
    [Serializable]
    public class FacebookOAuthException : Exception
    {
        /// <summary>
        /// An error code. Common values are listed below, along with common recovery tactics.
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Additional information about the error. Common values are listed below.
        /// </summary>
        public int SubCode { get; set; }

        /// <summary>
        /// Internal support identifier. When reporting a bug related to a Graph API call, include the <c>fbtrace_id</c> to help FB support find log data for debugging.
        /// </summary>
        public string FBTraceId { get; set; }

        /// <summary>
        /// The title of the dialog, if shown.
        /// </summary>
        public string ErrorUserTitle { get; set; }

        /// <summary>
        /// The message to display to the user.
        /// </summary>
        public string ErrorUserMessage { get; set; }

        /// <summary>
        /// FBRev
        /// </summary>
        public string FBRev { get; set; }

        /// <summary>
        /// FBDebug
        /// </summary>
        public string FBDebug { get; set; }

        /// <summary>
        /// Excecption message as it is received from API
        /// </summary>
        public string RawExceptionString { get; set; }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookOAuthException"/>
        /// </summary>
        /// <param name="exceptionCode">API Exception code</param>
        /// <param name="message">Exception message</param>
        public FacebookOAuthException(int exceptionCode, string message) : base(message)
        {
            Code = exceptionCode;
        }

        /// <summary>
        /// Initialize new instance of <see cref="FacebookOAuthException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected FacebookOAuthException(SerializationInfo info, StreamingContext context) : base(info, context)
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

            info.AddValue("Code", Code);
            info.AddValue("SubCode", SubCode);
            info.AddValue("FBTraceId", FBTraceId);
            info.AddValue("ErrorUserTitle", ErrorUserTitle);
            info.AddValue("ErrorUserMessage", ErrorUserMessage);
            info.AddValue("FBRev", FBRev);
            info.AddValue("FBDebug", FBDebug);
            info.AddValue("RawExceptionString", RawExceptionString);

            base.GetObjectData(info, context);
        }
    }
}
