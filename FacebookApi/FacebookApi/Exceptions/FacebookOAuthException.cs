using System;

namespace FacebookApi.Exceptions
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

        public string FBRev { get; set; }

        public string Type { get; set; }

        public string FBDebug { get; set; }

        public FacebookOAuthException(int exceptionCode, string message) : base(message)
        {
            Code = exceptionCode;
        }
    }
}
