using System.Collections.Generic;
using FacebookApi.Entities.Enumerations;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Link Data is one field within the creative that is used to create link ads.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data/</para>
    /// </summary>
    public class AdCreativeLinkData
    {
        /// <summary>
        /// The index (zero based) of the image from the additionalimages array to use as the ad image for a dynamic product ad
        /// </summary>
        [DeserializeAs(Name = "additional_image_index")]
        public int? AdditinalImageIndex { get; set; }

        /// <summary>
        /// Native deeplinks attached to the post
        /// </summary>
        [DeserializeAs(Name = "app_link_spec")]
        public AdCreativeLinkDataAppLinkSpec ApplinkSpec { get; set; }

        /// <summary>
        /// The style of the attachment.
        /// </summary>
        [DeserializeAs(Name = "attachment_style")]
        public AttachmentStyle? AttachmentStyle { get; set; }

        /// <summary>
        /// The branded content sponsor page id.
        /// </summary>
        [DeserializeAs(Name = "branded_content_sponsor_page_id")]
        public string BrandedVontentSponsorPageId { get; set; }

        /// <summary>
        /// An optional call to action button. If not specified, on Instagram, a default CTA would be used,
        /// </summary>
        [DeserializeAs(Name = "call_to_action")]
        public AdCreativeLinkDataCallToAction CallToAction { get; set; }

        /// <summary>
        /// Link caption. Overwrites the caption under the title in the link on Facebook.
        /// </summary>
        [DeserializeAs(Name = "caption")]
        public string Caption { get; set; }

        /// <summary>
        /// A 2-10 element array of link objects required for carousel ads
        /// </summary>
        [DeserializeAs(Name = "child_attachments")]
        public List<AdCreativeLinkDataChildAttachment> ChildAttachments { get; set; }

        /// <summary>
        /// Link description. Overwrites the description in the link on Facebook.
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The id of a Facebook event. This is only to be used if this creative is for a Website Clicks campaign, the Call To Action is Buy Tickets, and the link points to the ticketing website of this Facebook event.
        /// </summary>
        [DeserializeAs(Name = "event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// Whether to force the post to render in a single link format
        /// </summary>
        [DeserializeAs(Name = "force_single_link")]
        public bool? ForceSingleLink { get; set; }

        /// <summary>
        /// How to the image should be cropped. Different placements use different crop specs
        /// </summary>
        [DeserializeAs(Name = "image_crops")]
        public AdsImageCrops ImageCrops { get; set; }

        /// <summary>
        /// Hash of an image in your image library with Facebook. Specify this field or picture but not both
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        public string ImageHash { get; set; }

        /// <summary>
        /// Link url.
        /// </summary>
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The main body of the post.
        /// </summary>
        [DeserializeAs(Name = "message")]
        public string Message { get; set; }

        /// <summary>
        /// If set to false, removes the end card which displays the page icon. Default is true. Used by carousel ads.
        /// </summary>
        [DeserializeAs(Name = "multi_share_end_card")]
        public bool? MultiShareEndCard { get; set; }

        /// <summary>
        /// If set to true, automatically select and order images and links. Default is true. Used by carousel ads.
        /// </summary>
        [DeserializeAs(Name = "multi_share_optimized")]
        public bool? MultiShareOptimized { get; set; }

        /// <summary>
        /// Name of the link. Overwrites the title of the link preview
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The id of a Facebook native offer.
        /// </summary>
        [DeserializeAs(Name = "offer_id")]
        public string OfferId { get; set; }

        /// <summary>
        /// URL of a picture to use in the post. Specify this field or image_hash but not both.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        public string Picture { get; set; }
    }
}
