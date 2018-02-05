using Facebook.ApiClient.Enumerations.ApiEngine;

namespace Facebook.ApiClient.Entities.ApiEngine
{
    /// <summary>
    /// Represents request parameter in api call
    /// </summary>
    public class ApiRequestParameter
    {
        /// <summary>
        /// Name of the request parameterS
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of request parameter 
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Type of request parameter
        /// </summary>
        public ApiRequestParameterType ParameterType { get; set; }
    }
}
