using FacebookApi.Entities.Api;
using FacebookApi.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A recommendation object that suggests potential improvements around the ad object's configuration.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-recommendation/</para>
    /// </summary>
    public class AdRecommendation : BaseEntity
    {
        /// <summary>
        /// Field to associate the recommendation with (optional)
        /// </summary>
        [DeserializeAs(Name = "blame_field")]
        [JsonProperty(PropertyName = "blame_field", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BlameField { get; set; }

        /// <summary>
        /// Unique recommendation code
        /// </summary>
        [DeserializeAs(Name = "code")]
        [JsonProperty(PropertyName = "code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Code { get; set; }

        /// <summary>
        /// Indicator of how reliable recommendation is
        /// </summary>
        [DeserializeAs(Name = "confidence")]
        [JsonProperty(PropertyName = "confidence", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdRecommendationConfidence Confidence { get; set; }

        /// <summary>
        /// Indicator of how important recommendation is
        /// </summary>
        [DeserializeAs(Name = "importance")]
        [JsonProperty(PropertyName = "importance", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdRecommendationImportance Importance { get; set; }

        /// <summary>
        /// Content of the recommendation message
        /// </summary>
        [DeserializeAs(Name = "message")]
        [JsonProperty(PropertyName = "message", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Message { get; set; }

        /// <summary>
        /// Additional data associated with the recommendation.
        /// </summary>
        [DeserializeAs(Name = "recommendation_data")]
        [JsonProperty(PropertyName = "recommendation_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string RecommendationData { get; set; }

        /// <summary>
        /// Recommendation title
        /// </summary>
        [DeserializeAs(Name = "title")]
        [JsonProperty(PropertyName = "title", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Title { get; set; }
    }
}
