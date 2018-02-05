using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.ApiEngine
{
    /// <summary>
    /// Represents batch response header
    /// </summary>
    public class BatchResponseHeader
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
