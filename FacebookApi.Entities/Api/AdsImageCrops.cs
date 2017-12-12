using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Image crops specification, in the format of [[{left},{top}],[{right},{bottom}]]
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ads-image-crops/</para>
    /// </summary>
    public class AdsImageCrops : BaseEntity
    {
        /// <summary>
        /// Crop specification for 100x100
        /// </summary>
        [DeserializeAs(Name = "100x100")]
        [JsonProperty(PropertyName = "100x100", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _100x100 { get; set; }

        /// <summary>
        /// Crop specification for 100x72
        /// </summary>
        [DeserializeAs(Name = "100x72")]
        [JsonProperty(PropertyName = "100x72", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _100x72 { get; set; }

        /// <summary>
        /// Crop specification for 191x100
        /// </summary>
        [DeserializeAs(Name = "191x100")]
        [JsonProperty(PropertyName = "191x100", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _191x100 { get; set; }

        /// <summary>
        /// Crop specification for 400x150
        /// </summary>
        [DeserializeAs(Name = "400x150")]
        [JsonProperty(PropertyName = "400x150", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _400x150 { get; set; }


        /// <summary>
        /// Crop specification for 400x500
        /// </summary>
        [DeserializeAs(Name = "400x500")]
        [JsonProperty(PropertyName = "400x500", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _400x500 { get; set; }

        /// <summary>
        /// Crop specification for 600x360
        /// </summary>
        [DeserializeAs(Name = "600x360")]
        [JsonProperty(PropertyName = "600x360", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _600x360 { get; set; }

        /// <summary>
        /// Crop specification for 90x160
        /// </summary>
        [DeserializeAs(Name = "90x160")]
        [JsonProperty(PropertyName = "90x160", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _90x160 { get; set; }
    }
}
