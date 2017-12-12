using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The review feedback for the ad after it is reviewed.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/adgroup-review-feedback/</para>
    /// </summary>
    public class AdgroupReviewFeedback : BaseEntity
    {
        /// <summary>
        /// Reasons for review disapproval across all platforms, such as facebook or instagram. 
        /// </summary>
        [DeserializeAs(Name = "global")]
        [JsonProperty(PropertyName = "global", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IDictionary<string, string> Global { get; set; }

        /// <summary>
        /// Reasons for review disapproval on a certain platform, such as facebook or instagram.
        /// </summary>
        [DeserializeAs(Name = "placement_specific")]
        [JsonProperty(PropertyName = "placement_specific", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdgroupPlacementSpecificReviewFeedback PlacementSpecific { get; set; }
    }
}
