using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Data defining a text page post used for an ad.
    /// </summary>
    public class AdCreativeTextData : BaseEntity
    {
        /// <summary>
        /// The text of the page post.
        /// </summary>
        [DeserializeAs(Name = "message")]
        [JsonProperty(PropertyName = "message", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Message { get; set; }
    }
}
