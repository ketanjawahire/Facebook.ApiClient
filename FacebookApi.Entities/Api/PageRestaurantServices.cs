using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Services that a Resturant that's represented as a Facebook Page might provide
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-restaurant-services/</para>
    /// </summary>
    public class PageRestaurantServices : BaseEntity
    {
        /// <summary>
        /// Whether the restaurant has catering service
        /// </summary>
        [DeserializeAs(Name = "catering")]
        [JsonProperty(PropertyName = "catering", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Catering { get; set; }

        /// <summary>
        /// Whether the restaurant has delivery service
        /// </summary>
        [DeserializeAs(Name = "delivery")]
        [JsonProperty(PropertyName = "delivery", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Delivery { get; set; }

        /// <summary>
        /// Whether the restaurant is group-friendly
        /// </summary>
        [DeserializeAs(Name = "groups")]
        [JsonProperty(PropertyName = "groups", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Groups { get; set; }

        /// <summary>
        /// Whether the restaurant is kids-friendly
        /// </summary>
        [DeserializeAs(Name = "kids")]
        [JsonProperty(PropertyName = "kids", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Kids { get; set; }

        /// <summary>
        /// Whether the restaurant has outdoor seating
        /// </summary>
        [DeserializeAs(Name = "outdoor")]
        [JsonProperty(PropertyName = "outdoor", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Outdoor { get; set; }

        /// <summary>
        /// Whether the restaurant takes reservations
        /// </summary>
        [DeserializeAs(Name = "reserve")]
        [JsonProperty(PropertyName = "reserve", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Reserve { get; set; }

        /// <summary>
        /// Whether the restaurant has takeout service
        /// </summary>
        [DeserializeAs(Name = "takeout")]
        [JsonProperty(PropertyName = "takeout", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Takeout { get; set; }

        /// <summary>
        /// Whether the restaurant has waiters
        /// </summary>
        [DeserializeAs(Name = "waiter")]
        [JsonProperty(PropertyName = "waiter", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Waiter { get; set; }

        /// <summary>
        /// Whether the restaurant welcomes walkins
        /// </summary>
        [DeserializeAs(Name = "walkins")]
        [JsonProperty(PropertyName = "walkins", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Walkins { get; set; }
    }
}
