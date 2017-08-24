using FacebookApi.Interfaces.IApiEngine;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.ApiEngine
{
    /// <summary>
    /// Represents batch response header
    /// </summary>
    public class BatchResponceHeader : IBatchResponceHeader
    {
        /// <summary>
        /// Name of header key
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Header  value
        /// </summary>
        [DeserializeAs(Name = "value")]
        public string Value { get; set; }
    }
}
