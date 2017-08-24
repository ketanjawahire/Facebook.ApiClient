using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Social context for Graph API objects.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/open-graph-context/</para>
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
