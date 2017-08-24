using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Video Data is one field within the creative that is used to create video ads. 
    /// </summary>
    public class AdCreativeVideoData
    {
        /// <summary>
        /// The branded content sponsor page id.
        /// </summary>
        [DeserializeAs(Name = "branded_content_sponsor_page_id")]
        public string BrandedContentSponsorPageId { get; set; }

        /// <summary>
        /// An optional call to action. Additionally you can specify a LIKE_PAGE call to action when the ad is in a PAGE_LIKES campaign.
        /// </summary>
        [DeserializeAs(Name = "call_to_action")]
        public AdCreativeLinkDataCallToAction CallToAction { get; set; }

        /// <summary>
        /// The description of the video
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Hash of an image in your image library with Facebook to use as thumbnail
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        public string ImageHash { get; set; }

        /// <summary>
        /// URL of image to use as thumbnail. You should not use image URLs returned from the FB CDN but instead have the image hosted on your own servers. The image specified at the URL will be saved into the ad accounts image library
        /// </summary>
        [DeserializeAs(Name = "image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The post gating for the video.
        /// </summary>
        [DeserializeAs(Name = "targeting")]
        public string Targeting { get; set; }

        /// <summary>
        /// The title of the video
        /// </summary>
        [DeserializeAs(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// ID of video that user has permission to or a video in ad account video library.
        /// </summary>
        [DeserializeAs(Name = "video_id")]
        public string VideoId { get; set; }
    }
}
