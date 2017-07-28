using FacebookApi.Enums;
using FacebookApi.Interfaces.IApiEngine;

namespace FacebookApi.ApiEngine
{
    /// <summary>
    /// Represents request parameter in api call
    /// </summary>
    public class ApiRequestParameter : IApiRequestParameter
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
        public ApiRequestParameterType Type { get; set; }
    }
}
