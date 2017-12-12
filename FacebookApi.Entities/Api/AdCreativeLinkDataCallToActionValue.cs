using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// JSON containing the call to action data.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data-call-to-action-value/</para>
    /// </summary>
    public class AdCreativeLinkDataCallToActionValue : BaseEntity
    {
        /// <summary>
        /// The app destination type.
        /// </summary>
        [DeserializeAs(Name = "app_destination")]
        [JsonProperty(PropertyName = "app_destination", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppDestination { get; set; }

        /// <summary>
        /// Deep link to the app.
        /// </summary>
        [DeserializeAs(Name = "app_link")]
        [JsonProperty(PropertyName = "app_link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppLink { get; set; }

        /// <summary>
        /// Application related to the action.
        /// </summary>
        [DeserializeAs(Name = "application")]
        [JsonProperty(PropertyName = "application", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Application { get; set; }

        /// <summary>
        /// ID of the Facebook event which the attachement show event info
        /// </summary>
        [DeserializeAs(Name = "event_id")]
        [JsonProperty(PropertyName = "event_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EventId { get; set; }

        /// <summary>
        /// The Lead Ad form id.
        /// </summary>
        [DeserializeAs(Name = "lead_gen_form_id")]
        [JsonProperty(PropertyName = "lead_gen_form_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LeadgenFromId { get; set; }

        /// <summary>
        /// The destination link when the CTA button is clicked.
        /// </summary>
        [DeserializeAs(Name = "link")]
        [JsonProperty(PropertyName = "link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Link { get; set; }

        /// <summary>
        /// Caption shown in the attachment.
        /// </summary>
        [DeserializeAs(Name = "link_caption")]
        [JsonProperty(PropertyName = "link_caption", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LinkCaption { get; set; }

        /// <summary>
        /// Description of the link shown in the attachment.
        /// </summary>
        [DeserializeAs(Name = "link_description")]
        [JsonProperty(PropertyName = "link_description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LinkDescription { get; set; }

        /// <summary>
        /// Link format of video.
        /// </summary>
        [DeserializeAs(Name = "link_format")]
        [JsonProperty(PropertyName = "link_format", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LinkFormat { get; set; }

        /// <summary>
        /// Title of the link shown in the attachment.
        /// </summary>
        [DeserializeAs(Name = "link_title")]
        [JsonProperty(PropertyName = "link_title", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LinkTitle { get; set; }

        /// <summary>
        /// ID of the Facebook page which the CTA button links to
        /// </summary>
        [DeserializeAs(Name = "page")]
        [JsonProperty(PropertyName = "page", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Page { get; set; }

        /// <summary>
        /// Open graph object url for canvas virtual good ads.
        /// </summary>
        [DeserializeAs(Name = "product_link")]
        [JsonProperty(PropertyName = "product_link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ProductLink { get; set; }
    }
}
