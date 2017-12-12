using System.Collections.Generic;
using FacebookApi.Entities.Api;
using FacebookApi.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Link Data is one field within the creative that is used to create link ads.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data/</para>
    /// </summary>
    public class AdCreativeLinkData : BaseEntity
    {
        /// <summary>
        /// The index (zero based) of the image from the additionalimages array to use as the ad image for a dynamic product ad
        /// </summary>
        [DeserializeAs(Name = "additional_image_index")]
        [JsonProperty(PropertyName = "additional_image_index", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? AdditinalImageIndex { get; set; }

        /// <summary>
        /// Native deeplinks attached to the post
        /// </summary>
        [DeserializeAs(Name = "app_link_spec")]
        [JsonProperty(PropertyName = "app_link_spec", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeLinkDataAppLinkSpec ApplinkSpec { get; set; }

        /// <summary>
        /// The style of the attachment.
        /// </summary>
        [DeserializeAs(Name = "attachment_style")]
        [JsonProperty(PropertyName = "attachment_style", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AttachmentStyle? AttachmentStyle { get; set; }

        /// <summary>
        /// The branded content sponsor page id.
        /// </summary>
        [DeserializeAs(Name = "branded_content_sponsor_page_id")]
        [JsonProperty(PropertyName = "branded_content_sponsor_page_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BrandedVontentSponsorPageId { get; set; }

        /// <summary>
        /// An optional call to action button. If not specified, on Instagram, a default CTA would be used,
        /// </summary>
        [DeserializeAs(Name = "call_to_action")]
        [JsonProperty(PropertyName = "call_to_action", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeLinkDataCallToAction CallToAction { get; set; }

        /// <summary>
        /// Link caption. Overwrites the caption under the title in the link on Facebook.
        /// </summary>
        [DeserializeAs(Name = "caption")]
        [JsonProperty(PropertyName = "caption", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Caption { get; set; }

        /// <summary>
        /// A 2-10 element array of link objects required for carousel ads
        /// </summary>
        [DeserializeAs(Name = "child_attachments")]
        [JsonProperty(PropertyName = "child_attachments", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdCreativeLinkDataChildAttachment> ChildAttachments { get; set; }

        /// <summary>
        /// Link description. Overwrites the description in the link on Facebook.
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// The id of a Facebook event. This is only to be used if this creative is for a Website Clicks campaign, the Call To Action is Buy Tickets, and the link points to the ticketing website of this Facebook event.
        /// </summary>
        [DeserializeAs(Name = "event_id")]
        [JsonProperty(PropertyName = "event_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EventId { get; set; }

        /// <summary>
        /// Whether to force the post to render in a single link format
        /// </summary>
        [DeserializeAs(Name = "force_single_link")]
        [JsonProperty(PropertyName = "force_single_link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? ForceSingleLink { get; set; }

        /// <summary>
        /// How to the image should be cropped. Different placements use different crop specs
        /// </summary>
        [DeserializeAs(Name = "image_crops")]
        [JsonProperty(PropertyName = "image_crops", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdsImageCrops ImageCrops { get; set; }

        /// <summary>
        /// Hash of an image in your image library with Facebook. Specify this field or picture but not both
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        [JsonProperty(PropertyName = "image_hash", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageHash { get; set; }

        /// <summary>
        /// Link url.
        /// </summary>
        [DeserializeAs(Name = "link")]
        [JsonProperty(PropertyName = "link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Link { get; set; }

        /// <summary>
        /// The main body of the post.
        /// </summary>
        [DeserializeAs(Name = "message")]
        [JsonProperty(PropertyName = "message", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Message { get; set; }

        /// <summary>
        /// If set to false, removes the end card which displays the page icon. Default is true. Used by carousel ads.
        /// </summary>
        [DeserializeAs(Name = "multi_share_end_card")]
        [JsonProperty(PropertyName = "multi_share_end_card", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? MultiShareEndCard { get; set; }

        /// <summary>
        /// If set to true, automatically select and order images and links. Default is true. Used by carousel ads.
        /// </summary>
        [DeserializeAs(Name = "multi_share_optimized")]
        [JsonProperty(PropertyName = "multi_share_optimized", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? MultiShareOptimized { get; set; }

        /// <summary>
        /// Name of the link. Overwrites the title of the link preview
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// The id of a Facebook native offer.
        /// </summary>
        [DeserializeAs(Name = "offer_id")]
        [JsonProperty(PropertyName = "offer_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string OfferId { get; set; }

        /// <summary>
        /// URL of a picture to use in the post. Specify this field or image_hash but not both.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        [JsonProperty(PropertyName = "picture", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Picture { get; set; }
    }
}
