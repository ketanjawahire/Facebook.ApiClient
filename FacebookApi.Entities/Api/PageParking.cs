using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Parking options for a Page.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-parking/</para>
    /// </summary>
    public class PageParking : BaseEntity
    {
        /// <summary>
        /// Whether lot parking is available
        /// </summary>
        [DeserializeAs(Name = "lot")]
        [JsonProperty(PropertyName = "lot", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Lot { get; set; }

        /// <summary>
        /// Whether street parking is available
        /// </summary>
        [DeserializeAs(Name = "street")]
        [JsonProperty(PropertyName = "street", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Street { get; set; }

        /// <summary>
        /// Whether valet parking is available
        /// </summary>
        [DeserializeAs(Name = "valet")]
        [JsonProperty(PropertyName = "valet", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Valet { get; set; }
    }
}
