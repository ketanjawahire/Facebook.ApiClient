using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Location node used with other objects in the Graph API.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/location/</para>
    /// </summary>
    public class Location : BaseEntity
    {
        /// <summary>
        /// City
        /// </summary>
        [DeserializeAs(Name = "city")]
        [JsonProperty(PropertyName = "city", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string City { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [DeserializeAs(Name = "country")]
        [JsonProperty(PropertyName = "country", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Country { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        [DeserializeAs(Name = "latitude")]
        [JsonProperty(PropertyName = "latitude", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float? Latitude { get; set; }

        /// <summary>
        /// The parent location if this location is located within another location
        /// </summary>
        [DeserializeAs(Name = "located_in")]
        [JsonProperty(PropertyName = "located_in", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LocatiedIn { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [DeserializeAs(Name = "longitude")]
        [JsonProperty(PropertyName = "longitude", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float? Longitude { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [DeserializeAs(Name = "region")]
        [JsonProperty(PropertyName = "region", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Region { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [DeserializeAs(Name = "state")]
        [JsonProperty(PropertyName = "state", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string State { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        [DeserializeAs(Name = "street")]
        [JsonProperty(PropertyName = "street", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Street { get; set; }

        /// <summary>
        /// Zip code
        /// </summary>
        [DeserializeAs(Name = "zip")]
        [JsonProperty(PropertyName = "zip", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ZipCode { get; set; }
    }
}
