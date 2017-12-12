using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specifications of a creative containing the page id and other content to create a new unpublished page post specified using one of link_data, photo_data, video_data, offer_data , text_data or template_data.
    /// </summary>
    public class ObjectStorySpec : BaseEntity
    {
        /// <summary>
        /// Object story id
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }

        /// <summary>
        /// The Instagram user account that the story will be posted to
        /// </summary>
        [DeserializeAs(Name = "instagram_actor_id")]
        [JsonProperty(PropertyName = "instagram_actor_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string InstagramActorId { get; set; }

        /// <summary>
        /// The spec for a link page post or carousel ad
        /// </summary>
        [DeserializeAs(Name = "link_data")]
        [JsonProperty(PropertyName = "link_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeLinkData LinkData { get; set; }

        /// <summary>
        /// The spec for an offer page post.
        /// </summary>
        [DeserializeAs(Name = "offer_data")]
        [JsonProperty(PropertyName = "offer_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeOfferData OfferData { get; set; }

        /// <summary>
        /// ID of a Facebook page. An unpublished page post will be created on this page. User must have Admin or Editor role for this page.
        /// </summary>
        [DeserializeAs(Name = "page_id")]
        [JsonProperty(PropertyName = "page_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PageId { get; set; }

        /// <summary>
        /// The spec for a photo page post.
        /// </summary>
        [DeserializeAs(Name = "photo_data")]
        [JsonProperty(PropertyName = "photo_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativePhotoData PhotoData { get; set; }

        /// <summary>
        /// The spec for a template link page post as used in Dynamic Product Ads.
        /// </summary>
        [DeserializeAs(Name = "template_data")]
        [JsonProperty(PropertyName = "template_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeLinkData TemplateData { get; set; }

        /// <summary>
        /// The spec for a text page post.
        /// </summary>
        [DeserializeAs(Name = "text_data")]
        [JsonProperty(PropertyName = "text_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeTextData TextData { get; set; }

        /// <summary>
        /// The spec for a video page post.
        /// </summary>
        [DeserializeAs(Name = "video_data")]
        [JsonProperty(PropertyName = "video_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeVideoData VideoData { get; set; }
    }
}
