using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The review feedback of an ad for each platform, such as facebook or instagram.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/adgroup-placement-specific-review-feedback/</para>
    /// </summary>
    public class AdgroupPlacementSpecificReviewFeedback : BaseEntity
    {
        /// <summary>
        /// Reasons for disapproval on "FACEBOOK".
        /// </summary>
        [DeserializeAs(Name = "facebook")]
        [JsonProperty(PropertyName = "facebook", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IDictionary<string, string> Facebook { get; set; }

        /// <summary>
        /// Reasons for disapproval on "INSTAGRAM". 
        /// </summary>
        [DeserializeAs(Name = "instagram")]
        [JsonProperty(PropertyName = "instagram", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IDictionary<string, string> Instagram { get; set; }
    }
}
