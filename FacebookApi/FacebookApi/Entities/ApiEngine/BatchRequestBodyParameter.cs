using FacebookApi.Interfaces.IApiEngine;

namespace FacebookApi.Entities.ApiEngine
{
    /// <summary>
    /// Represents batch request body parameter
    /// </summary>
    public class BatchRequestBodyParameter : IBatchRequestBodyParameter
    {
        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the parameter
        /// </summary>
        public string Value { get; set; }
    }
}
