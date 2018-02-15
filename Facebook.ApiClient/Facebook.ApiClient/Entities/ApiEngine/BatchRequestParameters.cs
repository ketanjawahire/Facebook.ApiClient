using System.Collections.Generic;
using Facebook.ApiClient.Enumerations.ApiEngine;

namespace Facebook.ApiClient.Entities.ApiEngine
{
    /// <summary>
    /// Represents Batch request parameter
    /// </summary>
    public class BatchRequestParameters
    {
        /// <summary>
        /// Name of the request. Used to identify request within batch.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Request method
        /// </summary>
        public ApiRequestHttpMethod Method { get; set; }

        /// <summary>
        /// Request url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Collection of request body parameters
        /// </summary>
        public IList<BatchRequestBodyParameter> Body { get; }

        /// <summary>
        /// If its a dependent request then specify dependent request
        /// </summary>
        public BatchRequestParameters DependsOn { get; set; }

        /// <summary>
        /// Initialize new instance of <see cref="BatchRequestParameters"/>
        /// </summary>
        public BatchRequestParameters()
        {
            Body = new List<BatchRequestBodyParameter>();
        }
    }
}
