using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Information about a person's VOIP status
    /// <para>https://developers.facebook.com/docs/graph-api/reference/voip-info/</para>
    /// </summary>
    public class VoipInfo : BaseEntity
    {
        /// <summary>
        /// Does this user have a pushable mobile app install?
        /// </summary>
        [DeserializeAs(Name = "has_mobile_app")]
        [JsonProperty(PropertyName = "has_mobile_app", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool HasMobileApp { get; set; }

        /// <summary>
        /// Does the viewer have permission to call?
        /// </summary>
        [DeserializeAs(Name = "has_permission")]
        [JsonProperty(PropertyName = "has_permission", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool HasPermission { get; set; }

        /// <summary>
        /// Is this user currently callable via mobile?
        /// </summary>
        [DeserializeAs(Name = "is_callable")]
        [JsonProperty(PropertyName = "is_callable", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsCallable { get; set; }

        /// <summary>
        /// Is this user currently callable via dekstop?
        /// </summary>
        [DeserializeAs(Name = "is_callable_webrtc")]
        [JsonProperty(PropertyName = "is_callable_webrtc", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsCallableWebrtc { get; set; }

        /// <summary>
        /// Does this user have an unmuted push token?
        /// </summary>
        [DeserializeAs(Name = "is_pushable")]
        [JsonProperty(PropertyName = "is_pushable", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string IsPushable { get; set; }

        /// <summary>
        /// Reason code if not callable
        /// </summary>
        [DeserializeAs(Name = "reason_code")]
        [JsonProperty(PropertyName = "reason_code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int ResonCode { get; set; }

        /// <summary>
        /// Reason description if not callable
        /// </summary>
        [DeserializeAs(Name = "reason_description")]
        [JsonProperty(PropertyName = "reason_description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ReasonDescription { get; set; }
    }
}
