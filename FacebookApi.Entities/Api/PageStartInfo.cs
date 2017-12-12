using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Information about when a business was started that's represented by a Facebook Page
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-start-info/</para>
    /// </summary>
    public class PageStartInfo : BaseEntity
    {
        /// <summary>
        /// The start date of the entity
        /// </summary>
        [DeserializeAs(Name = "date")]
        [JsonProperty(PropertyName = "date", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PageStartDate Date { get; set; }

        /// <summary>
        /// The start type of the entity
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }
    }
}
