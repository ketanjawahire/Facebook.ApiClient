using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specification for Web template spec.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-web-data/</para>
    /// </summary>
    public class AdCreativeWebData : BaseEntity
    {
        /// <summary>
        /// Indicates if the web url should be used as a fallback, defaults to true. If it is set to false, the content is meant to be viewed only on a native app.
        /// </summary>
        [DeserializeAs(Name = "should_fallback")]
        [JsonProperty(PropertyName = "should_fallback", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ShouldFallback { get; set; }

        /// <summary>
        /// The web url, e.g. http://www.expedia.com/?search={{hotel.name | urlencode}}
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Url { get; set; }
    }
}
