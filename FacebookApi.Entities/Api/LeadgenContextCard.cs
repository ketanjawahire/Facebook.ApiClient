using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Leadgen form context card
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_context_cards/</para>
    /// </summary>
    public class LeadgenContextCard : BaseEntity
    {
        /// <summary>
        /// Text shown on the CTA button of sticky footer
        /// </summary>
        [DeserializeAs(Name = "button_text")]
        [JsonProperty(PropertyName = "button_text", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ButtonText { get; set; }

        /// <summary>
        /// Content displayed on context card
        /// </summary>
        [DeserializeAs(Name = "content")]
        [JsonProperty(PropertyName = "content", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Content { get; set; }

        /// <summary>
        /// Cover photo shown on top of context card
        /// </summary>
        [DeserializeAs(Name = "cover_photo")]
        [JsonProperty(PropertyName = "cover_photo", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CoverPhoto { get; set; }

        /// <summary>
        /// ID of custom context card cover photo, used by form builder
        /// </summary>
        [DeserializeAs(Name = "cover_photo_id")]
        [JsonProperty(PropertyName = "cover_photo_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CoverPhotoId { get; set; }

        /// <summary>
        /// The status of the context card
        /// </summary>
        [DeserializeAs(Name = "status")]
        [JsonProperty(PropertyName = "status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Status { get; set; }

        /// <summary>
        /// Rendering style of context card content
        /// </summary>
        [DeserializeAs(Name = "style")]
        [JsonProperty(PropertyName = "style", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Style { get; set; }

        /// <summary>
        /// Title on context card
        /// </summary>
        [DeserializeAs(Name = "title")]
        [JsonProperty(PropertyName = "title", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Title { get; set; }
    }
}
