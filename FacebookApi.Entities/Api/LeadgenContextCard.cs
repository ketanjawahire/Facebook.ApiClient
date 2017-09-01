using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Leadgen form context card
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_context_cards/</para>
    /// </summary>
    public class LeadgenContextCard
    {
        /// <summary>
        /// Text shown on the CTA button of sticky footer
        /// </summary>
        [DeserializeAs(Name = "button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// Content displayed on context card
        /// </summary>
        [DeserializeAs(Name = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Cover photo shown on top of context card
        /// </summary>
        [DeserializeAs(Name = "cover_photo")]
        public string CoverPhoto { get; set; }

        /// <summary>
        /// ID of custom context card cover photo, used by form builder
        /// </summary>
        [DeserializeAs(Name = "cover_photo_id")]
        public string CoverPhotoId { get; set; }

        /// <summary>
        /// The status of the context card
        /// </summary>
        [DeserializeAs(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Rendering style of context card content
        /// </summary>
        [DeserializeAs(Name = "style")]
        public string Style { get; set; }

        /// <summary>
        /// Title on context card
        /// </summary>
        [DeserializeAs(Name = "title")]
        public string Title { get; set; }
    }
}