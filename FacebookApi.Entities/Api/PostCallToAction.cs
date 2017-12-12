using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The call to action type used in any Page posts for mobile app engagement ads.
    /// </summary>
    public class PostCallToAction : BaseEntity
    {
        /// <summary>
        /// Type
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [DeserializeAs(Name = "value")]
        [JsonProperty(PropertyName = "value", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PostCallToActionValue Value { get; set; }
    }
}
