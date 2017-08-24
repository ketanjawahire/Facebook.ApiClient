using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The web metadata for an app link
    /// <para>https://developers.facebook.com/docs/graph-api/reference/web-app-link/</para>
    /// </summary>
    public class WebAppLink
    {
        /// <summary>
        /// Describes if the web link should be used if the native links don't work
        /// </summary>
        [DeserializeAs(Name = "should_fallback")]
        public bool? ShouldFallback { get; set; }

        /// <summary>
        /// The web equivalent for an app link
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string URL { get; set; }
    }
}
