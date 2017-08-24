using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The review feedback for the ad after it is reviewed.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/adgroup-review-feedback/</para>
    /// </summary>
    public class AdgroupReviewFeedback
    {
        /// <summary>
        /// Reasons for review disapproval across all platforms, such as facebook or instagram. 
        /// </summary>
        [DeserializeAs(Name = "global")]
        public IDictionary<string,string> Global { get; set; }

        /// <summary>
        /// Reasons for review disapproval on a certain platform, such as facebook or instagram.
        /// </summary>
        [DeserializeAs(Name = "placement_specific")]
        public AdgroupPlacementSpecificReviewFeedback PlacementSpecific { get; set; }
    }
}
