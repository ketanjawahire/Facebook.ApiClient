using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// JSON containing the call to action data.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data-call-to-action-value/</para>
    /// </summary>
    public class AdCreativeLinkDataCallToActionValue
    {
        /// <summary>
        /// The app destination type.
        /// </summary>
        [DeserializeAs(Name = "app_destination")]
        public string AppDestination { get; set; }

        /// <summary>
        /// Deep link to the app.
        /// </summary>
        [DeserializeAs(Name = "app_link")]
        public string AppLink { get; set; }

        /// <summary>
        /// Application related to the action.
        /// </summary>
        [DeserializeAs(Name = "application")]
        public string Application { get; set; }

        /// <summary>
        /// ID of the Facebook event which the attachement show event info
        /// </summary>
        [DeserializeAs(Name = "event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// The Lead Ad form id.
        /// </summary>
        [DeserializeAs(Name = "lead_gen_form_id")]
        public string LeadgenFromId { get; set; }

        /// <summary>
        /// The destination link when the CTA button is clicked.
        /// </summary>
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Caption shown in the attachment.
        /// </summary>
        [DeserializeAs(Name = "link_caption")]
        public string LinkCaption { get; set; }

        /// <summary>
        /// Description of the link shown in the attachment.
        /// </summary>
        [DeserializeAs(Name = "link_description")]
        public string LinkDescription { get; set; }

        /// <summary>
        /// Link format of video.
        /// </summary>
        [DeserializeAs(Name = "link_format")]
        public string LinkFormat { get; set; }

        /// <summary>
        /// Title of the link shown in the attachment.
        /// </summary>
        [DeserializeAs(Name = "link_title")]
        public string LinkTitle { get; set; }

        /// <summary>
        /// ID of the Facebook page which the CTA button links to
        /// </summary>
        [DeserializeAs(Name = "page")]
        public string Page { get; set; }

        /// <summary>
        /// Open graph object url for canvas virtual good ads.
        /// </summary>
        [DeserializeAs(Name = "product_link")]
        public string ProductLink { get; set; }
    }
}
