using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Reach and Frequency Spec
    /// <para>https://developers.facebook.com/docs/marketing-api/reachandfrequency/v2.5</para>
    /// </summary>
    public class ReachFrequencySpec : BaseEntity
    {
        /// <summary>
        /// List of currently supported countries for reach and frequency buying
        /// </summary>
        [DeserializeAs(Name = "countries")]
        [JsonProperty(PropertyName = "countries", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<string> Countries { get; set; }

        /// <summary>
        /// Minimum campaign duration (in days) map for each of the supported countries
        /// </summary>
        [DeserializeAs(Name = "min_campaign_duration")]
        [JsonProperty(PropertyName = "min_campaign_duration", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MinCampaignDuration { get; set; }

        /// <summary>
        /// Maximum campaign duration (in days) map for each of the supported countries
        /// </summary>
        [DeserializeAs(Name = "max_campaign_duration")]
        [JsonProperty(PropertyName = "max_campaign_duration", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MaxCampaignDuration { get; set; }

        /// <summary>
        /// How many days in advance campaign can finish at the time of prediction, map for each of the supported countries
        /// </summary>
        [DeserializeAs(Name = "max_days_to_finish")]
        [JsonProperty(PropertyName = "max_days_to_finish", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MaxDaysToFinish { get; set; }

        /// <summary>
        /// Minimum reach limits (in number of users) map for each of the supported countries
        /// </summary>
        [DeserializeAs(Name = "min_reach_limits")]
        [JsonProperty(PropertyName = "min_reach_limits", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MinReachLimits { get; set; }
    }
}
