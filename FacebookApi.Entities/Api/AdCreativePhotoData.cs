using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Photo Data is one field within the creative that is used to create photo ads. 
    /// </summary>
    public class AdCreativePhotoData : BaseEntity
    {
        /// <summary>
        /// The branded content sponsor page ID. If your ad promotes branded content, you must use this to indicate the sponsor page
        /// </summary>
        [DeserializeAs(Name = "branded_content_sponsor_page_id")]
        [JsonProperty(PropertyName = "branded_content_sponsor_page_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BrandedContentSponsorPageId { get; set; }

        /// <summary>
        /// The description of the image
        /// </summary>
        [DeserializeAs(Name = "caption")]
        [JsonProperty(PropertyName = "caption", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Caption { get; set; }

        /// <summary>
        /// Hash of an image in your image library with Facebook. Specify this field or url but not both
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        [JsonProperty(PropertyName = "image_hash", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageHash { get; set; }

        /// <summary>
        /// URL of an image to use in the ad. Specify this field or image_hash but not both. The image specified at the URL will be saved into the ad accounts image library
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Url { get; set; }
    }
}
