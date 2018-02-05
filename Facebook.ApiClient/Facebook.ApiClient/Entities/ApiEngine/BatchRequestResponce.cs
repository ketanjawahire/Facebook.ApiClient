using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.ApiEngine
{
    /// <summary>
    /// Represents batch API request response
    /// </summary>
    public class BatchRequestResponse
    {
        /// <summary>
        /// Response code
        /// </summary>
        [DeserializeAs(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Response headers
        /// </summary>
        [DeserializeAs(Name = "headers")]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Response body
        /// </summary>
        [DeserializeAs(Name = "body")]
        public string Body { get; set; }
    }
}
