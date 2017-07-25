using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Reach and Frequency Spec
    /// <see cref="https://developers.facebook.com/docs/marketing-api/reachandfrequency/v2.5"/>
    /// </summary>
    public class ReachFrequencySpec
    {
        /// <summary>
        /// List of currently supported countries for reach and frequency buying
        /// </summary>
        [DeserializeAs(Name = "countries")]
        public IList<string> Countries { get; set; }

        /// <summary>
        /// Minimum campaign duration (in days) map for each of the supported countries
        /// </summary>
        [DeserializeAs(Name = "min_campaign_duration")]
        public string MinCampaignDuration { get; set; }

        /// <summary>
        /// Maximum campaign duration (in days) map for each of the supported countries
        /// </summary>
        [DeserializeAs(Name = "max_campaign_duration")]
        public string MaxCampaignDuration { get; set; }

        /// <summary>
        /// How many days in advance campaign can finish at the time of prediction, map for each of the supported countries
        /// </summary>
        [DeserializeAs(Name = "max_days_to_finish")]
        public string MaxDaysToFinish { get; set; }

        /// <summary>
        /// Minimum reach limits (in number of users) map for each of the supported countries
        /// </summary>
        [DeserializeAs(Name = "min_reach_limits")]
        public string MinReachLimits { get; set; }
    }
}
