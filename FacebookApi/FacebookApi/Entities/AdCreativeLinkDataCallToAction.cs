using FacebookApi.Enums;
using FacebookApi.Enums.Api;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Data defining the call to action for a link or video ad.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data-call-to-action/</para>
    /// </summary>
    public class AdCreativeLinkDataCallToAction
    {
        /// <summary>
        /// The type of the action. Not all types can be used for all ads
        /// </summary>
        [DeserializeAs(Name = "type")]
        public CreativeCallToActionType? Type { get; set; }

        /// <summary>
        /// JSON containing the call to action data.
        /// </summary>
        [DeserializeAs(Name = "value")]
        public AdCreativeLinkDataCallToActionValue Value { get; set; }
    }
}
