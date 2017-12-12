using FacebookApi.Entities.Api;
using FacebookApi.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Data defining the call to action for a link or video ad.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data-call-to-action/</para>
    /// </summary>
    public class AdCreativeLinkDataCallToAction : BaseEntity
    {
        /// <summary>
        /// The type of the action. Not all types can be used for all ads
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CreativeCallToActionType? Type { get; set; }

        /// <summary>
        /// JSON containing the call to action data.
        /// </summary>
        [DeserializeAs(Name = "value")]
        [JsonProperty(PropertyName = "value", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeLinkDataCallToActionValue Value { get; set; }
    }
}
