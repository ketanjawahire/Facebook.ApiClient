using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Social context for Graph API objects.
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/open-graph-context/"/>
    /// </summary>
    public class OpenGraphContext
    {
        /// <summary>
        /// The token representing the social context
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}
