using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Date about when the entity represented by the Page was started
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-start-date/</para>
    /// </summary>
    public class PageStartDate : BaseEntity
    {
        /// <summary>
        /// The start day of the entity
        /// </summary>
        [DeserializeAs(Name = "day")]
        [JsonProperty(PropertyName = "day", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Day { get; set; }

        /// <summary>
        /// The start month of the entity
        /// </summary>
        [DeserializeAs(Name = "month")]
        [JsonProperty(PropertyName = "month", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Month { get; set; }

        /// <summary>
        /// The start year of the entity
        /// </summary>
        [DeserializeAs(Name = "year")]
        [JsonProperty(PropertyName = "year", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Year { get; set; }
    }
}
