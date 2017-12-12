using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents leadgen form question options
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_forms/</para>
    /// </summary>
    public class LeadgenFormQuestionOption : BaseEntity
    {
        /// <summary>
        /// Key
        /// </summary>
        [DeserializeAs(Name = "key")]
        [JsonProperty(PropertyName = "key", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Key { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [DeserializeAs(Name = "value")]
        [JsonProperty(PropertyName = "value", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Value { get; set; }
    }
}
