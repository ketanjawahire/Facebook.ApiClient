using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Data defining a child attachment associated with a link ad, used for Carousel ads.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data-child-attachment/</para>
    /// </summary>
    public class AdCreativeLinkDataChildAttachment
    {
        /// <summary>
        /// Call to action of this attachment
        /// </summary>
        [DeserializeAs(Name = "call_to_action")]
        public AdCreativeLinkDataCallToAction CallToAction { get; set; }

        /// <summary>
        /// The display url shown at the end of a video, if the attachment is a video
        /// </summary>
        [DeserializeAs(Name = "caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Overwrites the description of each attachment on Facebook, not used on Instagram.
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Image crops, using the crop spec with 100x100 key for Carousel ads. If no 100x100 crop spec is provided, the image would be cropped automatically, unless the image is square already. The final cropped image size needs to be at least 200x200 pixels for Facebook, or 600x600 for Instagram.
        /// </summary>
        [DeserializeAs(Name = "image_crops")]
        public AdsImageCrops ImageCrops { get; set; }

        /// <summary>
        /// The image hash of an uploaded image for this attachment.
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        public string ImageHash { get; set; }

        /// <summary>
        /// The link of this attachment.
        /// </summary>
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Overwrites the title of the attachment on Facebook, not used on Instagram.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The url of an image for this attachment. For an ad on Facebook, if neither picture nor image_hash is set, the image specified in link_data above will be used. For an ad on Instagram, either picture or image_hash is required.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        public string Picture { get; set; }

        /// <summary>
        /// Whether to force the card to render statically, even in a dynamic ad.
        /// </summary>
        [DeserializeAs(Name = "static_card")]
        public bool StaticCard { get; set; }

        /// <summary>
        /// ID of an uploaded video, if this attachment is a video. Not supported for Instagram ads.
        /// </summary>
        [DeserializeAs(Name = "video_id")]
        public string VideoId { get; set; }
    }
}
