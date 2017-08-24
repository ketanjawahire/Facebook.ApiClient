using FacebookApi.Entities.Enumerations;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A recommendation object that suggests potential improvements around the ad object's configuration.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-recommendation/</para>
    /// </summary>
    public class AdRecommendation
    {
        /// <summary>
        /// Field to associate the recommendation with (optional)
        /// </summary>
        [DeserializeAs(Name = "blame_field")]
        public string BlameField { get; set; }

        /// <summary>
        /// Unique recommendation code
        /// </summary>
        [DeserializeAs(Name = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Indicator of how reliable recommendation is
        /// </summary>
        [DeserializeAs(Name = "confidence")]
        public AdRecommendationConfidence Confidence { get; set; }

        /// <summary>
        /// Indicator of how important recommendation is
        /// </summary>
        [DeserializeAs(Name = "importance")]
        public AdRecommendationImportance Importance { get; set; }

        /// <summary>
        /// Content of the recommendation message
        /// </summary>
        [DeserializeAs(Name = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Additional data associated with the recommendation.
        /// </summary>
        [DeserializeAs(Name = "recommendation_data")]
        public string RecommendationData { get; set; }

        /// <summary>
        /// Recommendation title
        /// </summary>
        [DeserializeAs(Name = "title")]
        public string Title { get; set; }
    }
}
