using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The web metadata for an app link
    /// <para>https://developers.facebook.com/docs/graph-api/reference/web-app-link/</para>
    /// </summary>
    public class WebAppLink : BaseEntity
    {
        /// <summary>
        /// Describes if the web link should be used if the native links don't work
        /// </summary>
        [DeserializeAs(Name = "should_fallback")]
        [JsonProperty(PropertyName = "should_fallback", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? ShouldFallback { get; set; }

        /// <summary>
        /// The web equivalent for an app link
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string URL { get; set; }
    }
}
