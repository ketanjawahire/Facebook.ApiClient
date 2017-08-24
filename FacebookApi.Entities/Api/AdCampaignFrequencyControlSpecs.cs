using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A frequency control spec specifies settings for frequency capping.
    /// </summary>
    /// <example>For example, {"event": "IMPRESSIONS", "interval_days":3, "max_frequency":1} means that in every 3 days, not more than 1 impression per user.</example>
    public class AdCampaignFrequencyControlSpecs
    {
        /// <summary>
        /// Event name, only IMPRESSIONS currently.
        /// </summary>
        [DeserializeAs(Name = "enum")]
        public string Enum { get; set; }

        /// <summary>
        /// Interval period in days, between 1 and 90 (inclusive)
        /// </summary>
        [DeserializeAs(Name = "interval_days")]
        public int? IntervalDays { get; set; }

        /// <summary>
        /// The maximum frequency, between 1 and 90 (inclusive)
        /// </summary>
        [DeserializeAs(Name = "max_frequency")]
        public int? MaxFrequency { get; set; }
    }
}
