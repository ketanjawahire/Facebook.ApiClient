using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The media that is used on a Facebook placement. The media specified here replaces the media orginally defined in the ad creative when the ad displays in an associated placement.
    /// </summary>
    public class AdCreativePlatformCustomizationOverride
    {
        /// <summary>
        /// A JSON object defining crop dimensions for the image specified
        /// </summary>
        [DeserializeAs(Name = "image_crops")]
        public AdsImageCrops ImageCrops { get; set; }

        /// <summary>
        /// The image used for the platform specific media.
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        public string ImageHash { get; set; }

        /// <summary>
        /// The URL of the image used for the platform specific media.
        /// </summary>
        [DeserializeAs(Name = "image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The ID of the video used for the platform specific media.
        /// </summary>
        [DeserializeAs(Name = "video_id")]
        public string VideoId { get; set; }
    }
}
