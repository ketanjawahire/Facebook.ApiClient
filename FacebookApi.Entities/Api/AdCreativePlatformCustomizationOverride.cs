using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The media that is used on a Facebook placement. The media specified here replaces the media orginally defined in the ad creative when the ad displays in an associated placement.
    /// </summary>
    public class AdCreativePlatformCustomizationOverride : BaseEntity
    {
        /// <summary>
        /// A JSON object defining crop dimensions for the image specified
        /// </summary>
        [DeserializeAs(Name = "image_crops")]
        [JsonProperty(PropertyName = "image_crops", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdsImageCrops ImageCrops { get; set; }

        /// <summary>
        /// The image used for the platform specific media.
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        [JsonProperty(PropertyName = "image_hash", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageHash { get; set; }

        /// <summary>
        /// The URL of the image used for the platform specific media.
        /// </summary>
        [DeserializeAs(Name = "image_url")]
        [JsonProperty(PropertyName = "image_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The ID of the video used for the platform specific media.
        /// </summary>
        [DeserializeAs(Name = "video_id")]
        [JsonProperty(PropertyName = "video_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string VideoId { get; set; }
    }
}
