using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Use this field to customize the media for different Facebook placements. Currently you can use this field for customizing images only
    /// </summary>
    public class AdCreativePlatformCustomization : BaseEntity
    {
        /// <summary>
        /// Media used on Instagram
        /// </summary>
        [DeserializeAs(Name = "instagram")]
        [JsonProperty(PropertyName = "instagram", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativePlatformCustomizationOverride Instagram { get; set; }
    }
}
