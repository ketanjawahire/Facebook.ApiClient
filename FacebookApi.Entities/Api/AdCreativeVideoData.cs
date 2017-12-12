using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Video Data is one field within the creative that is used to create video ads. 
    /// </summary>
    public class AdCreativeVideoData : BaseEntity
    {
        /// <summary>
        /// The branded content sponsor page id.
        /// </summary>
        [DeserializeAs(Name = "branded_content_sponsor_page_id")]
        [JsonProperty(PropertyName = "branded_content_sponsor_page_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BrandedContentSponsorPageId { get; set; }

        /// <summary>
        /// An optional call to action. Additionally you can specify a LIKE_PAGE call to action when the ad is in a PAGE_LIKES campaign.
        /// </summary>
        [DeserializeAs(Name = "call_to_action")]
        [JsonProperty(PropertyName = "call_to_action", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeLinkDataCallToAction CallToAction { get; set; }

        /// <summary>
        /// The description of the video
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// Hash of an image in your image library with Facebook to use as thumbnail
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        [JsonProperty(PropertyName = "image_hash", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageHash { get; set; }

        /// <summary>
        /// URL of image to use as thumbnail. You should not use image URLs returned from the FB CDN but instead have the image hosted on your own servers. The image specified at the URL will be saved into the ad accounts image library
        /// </summary>
        [DeserializeAs(Name = "image_url")]
        [JsonProperty(PropertyName = "image_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The post gating for the video.
        /// </summary>
        [DeserializeAs(Name = "targeting")]
        [JsonProperty(PropertyName = "targeting", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Targeting { get; set; }

        /// <summary>
        /// The title of the video
        /// </summary>
        [DeserializeAs(Name = "title")]
        [JsonProperty(PropertyName = "title", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Title { get; set; }

        /// <summary>
        /// ID of video that user has permission to or a video in ad account video library.
        /// </summary>
        [DeserializeAs(Name = "video_id")]
        [JsonProperty(PropertyName = "video_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string VideoId { get; set; }
    }
}
