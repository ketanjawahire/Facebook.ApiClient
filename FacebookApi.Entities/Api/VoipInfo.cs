using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Information about a person's VOIP status
    /// <para>https://developers.facebook.com/docs/graph-api/reference/voip-info/</para>
    /// </summary>
    public class VoipInfo
    {
        /// <summary>
        /// Does this user have a pushable mobile app install?
        /// </summary>
        [DeserializeAs(Name = "has_mobile_app")]
        public bool HasMobileApp { get; set; }

        /// <summary>
        /// Does the viewer have permission to call?
        /// </summary>
        [DeserializeAs(Name = "has_permission")]
        public bool HasPermission { get; set; }

        /// <summary>
        /// Is this user currently callable via mobile?
        /// </summary>
        [DeserializeAs(Name = "is_callable")]
        public bool IsCallable { get; set; }

        /// <summary>
        /// Is this user currently callable via dekstop?
        /// </summary>
        [DeserializeAs(Name = "is_callable_webrtc")]
        public bool IsCallableWebrtc { get; set; }

        /// <summary>
        /// Does this user have an unmuted push token?
        /// </summary>
        [DeserializeAs(Name = "is_pushable")]
        public string IsPushable { get; set; }

        /// <summary>
        /// Reason code if not callable
        /// </summary>
        [DeserializeAs(Name = "reason_code")]
        public int ResonCode { get; set; }

        /// <summary>
        /// Reason description if not callable
        /// </summary>
        [DeserializeAs(Name = "reason_description")]
        public string ReasonDescription { get; set; }
    }
}
