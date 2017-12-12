using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Social context for Graph API objects.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/open-graph-context/</para>
    /// </summary>
    public class OpenGraphContext : BaseEntity
    {
        /// <summary>
        /// The token representing the social context
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }
    }
}
