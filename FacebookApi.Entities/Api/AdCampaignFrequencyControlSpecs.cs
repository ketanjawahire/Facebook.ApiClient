using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A frequency control spec specifies settings for frequency capping.
    /// </summary>
    /// <example>For example, {"event": "IMPRESSIONS", "interval_days":3, "max_frequency":1} means that in every 3 days, not more than 1 impression per user.</example>
    public class AdCampaignFrequencyControlSpecs : BaseEntity
    {
        /// <summary>
        /// Event name, only IMPRESSIONS currently.
        /// </summary>
        [DeserializeAs(Name = "enum")]
        [JsonProperty(PropertyName = "enum", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Enum { get; set; }

        /// <summary>
        /// Interval period in days, between 1 and 90 (inclusive)
        /// </summary>
        [DeserializeAs(Name = "interval_days")]
        [JsonProperty(PropertyName = "interval_days", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? IntervalDays { get; set; }

        /// <summary>
        /// The maximum frequency, between 1 and 90 (inclusive)
        /// </summary>
        [DeserializeAs(Name = "max_frequency")]
        [JsonProperty(PropertyName = "max_frequency", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? MaxFrequency { get; set; }
    }
}
