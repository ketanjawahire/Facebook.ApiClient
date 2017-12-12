using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Specialties of a restaurant that is represented by a Facebook Page
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-restaurant-specialties/</para>
    /// </summary>
    public class PageRestaurantSpecialties : BaseEntity
    {
        /// <summary>
        /// Whether the restaurant serves breakfast
        /// </summary>
        [DeserializeAs(Name = "breakfast")]
        [JsonProperty(PropertyName = "breakfast", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Breakfast { get; set; }

        /// <summary>
        /// Whether the restaurant serves coffee
        /// </summary>
        [DeserializeAs(Name = "coffee")]
        [JsonProperty(PropertyName = "coffee", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Coffee { get; set; }

        /// <summary>
        /// Whether the restaurant serves dinner
        /// </summary>
        [DeserializeAs(Name = "dinner")]
        [JsonProperty(PropertyName = "dinner", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Dinner { get; set; }

        /// <summary>
        /// Whether the restaurant serves drinks
        /// </summary>
        [DeserializeAs(Name = "drinks")]
        [JsonProperty(PropertyName = "drinks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Drinks { get; set; }

        /// <summary>
        /// Whether the restaurant serves lunch
        /// </summary>
        [DeserializeAs(Name = "lunch")]
        [JsonProperty(PropertyName = "lunch", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Lunch { get; set; }
    }
}
