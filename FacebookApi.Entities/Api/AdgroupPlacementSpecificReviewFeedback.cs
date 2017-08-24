using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The review feedback of an ad for each platform, such as facebook or instagram.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/adgroup-placement-specific-review-feedback/</para>
    /// </summary>
    public class AdgroupPlacementSpecificReviewFeedback
    {
        /// <summary>
        /// Reasons for disapproval on "FACEBOOK".
        /// </summary>
        [DeserializeAs(Name = "facebook")]
        public IDictionary<string,string> Facebook { get; set; }

        /// <summary>
        /// Reasons for disapproval on "INSTAGRAM". 
        /// </summary>
        [DeserializeAs(Name = "instagram")]
        public IDictionary<string, string> Instagram { get; set; }
    }
}
