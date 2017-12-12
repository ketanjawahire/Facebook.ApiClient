using System;
using System.Collections.Generic;
using System.Linq;
using FacebookApi.Entities.Api;
using FacebookApi.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An ad set is a group of ads that share the same daily or lifetime budget, schedule, bid type, bid info, and targeting data. 
    /// <para>Ad sets enable you to group ads according to your criteria, and you can retrieve the ad-related statistics that apply to a set. </para>
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-campaign</para>
    /// </summary>
    public class AdSet : BaseEntity
    {
        /// <summary>
        /// Ad set ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// Ad Account ID
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        [JsonProperty(PropertyName = "account_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Ad Labels associated with this ad set
        /// </summary>
        [DeserializeAs(Name = "adlabels")]
        [JsonProperty(PropertyName = "adlabels", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdLabels { get; set; }

        /// <summary>
        /// Ad set schedule, representing a delivery schedule for a single days
        /// </summary>
        [DeserializeAs(Name = "adset_schedule")]
        [JsonProperty(PropertyName = "adset_schedule", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdSetSchedule { get; set; }

        /// <summary>
        /// Conversion attribution spec used for attributing conversions for optimization. Supported window lengths differ by optimization goal and campaign objective
        /// </summary>
        [DeserializeAs(Name = "attribution_spec")]
        [JsonProperty(PropertyName = "attribution_spec", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AttributionSpec { get; set; }

        /// <summary>
        /// Bid amount for this ad set, defined as your true value bid based on <see cref="OptimizationGoal"/>
        /// </summary>
        [DeserializeAs(Name = "bid_amount")]
        [JsonProperty(PropertyName = "bid_amount", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public decimal? BidAmount { get; set; }

        /// <summary>
        /// Map of bid objective to bid value. This field is not available if is_autobid is true.
        /// </summary>
        [DeserializeAs(Name = "bid_info")]
        [JsonProperty(PropertyName = "bid_info", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Dictionary<string, int> BidInfo { get; set; }

        /// <summary>
        /// The billing event that this adset is using
        /// </summary>
        [DeserializeAs(Name = "billing_event")]
        [JsonProperty(PropertyName = "billing_event", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public BillingEvent? BillingEvent { get; set; }

        /// <summary>
        /// Remaining budget
        /// </summary>
        [DeserializeAs(Name = "budget_remaining")]
        [JsonProperty(PropertyName = "budget_remaining", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public decimal? BudgetRemaining { get; set; }

        /// <summary>
        /// The campaign that contains this ad set
        /// </summary>
        [DeserializeAs(Name = "campaign")]
        [JsonProperty(PropertyName = "campaign", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Campaign Campaign { get; set; }

        /// <summary>
        /// Campaign ID
        /// </summary>
        [DeserializeAs(Name = "campaign_id")]
        [JsonProperty(PropertyName = "campaign_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? CampaignId { get; set; }

        /// <summary>
        /// The status set at the ad set level. It can be different from the effective status due to its parent campaign. Prefer using 'status' instead of this.
        /// </summary>
        [DeserializeAs(Name = "configured_status")]
        [JsonProperty(PropertyName = "configured_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdsetConfiguredStatus? ConfiguredStatus { get; set; }

        /// <summary>
        /// Created time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Order of the adgroup sequence to be shown to users
        /// </summary>
        [DeserializeAs(Name = "creative_sequence")]
        [JsonProperty(PropertyName = "creative_sequence", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> CreativeSequence { get; set; }

        /// <summary>
        /// The daily budget of the set defined in your account currency.
        /// </summary>
        [DeserializeAs(Name = "daily_budget")]
        [JsonProperty(PropertyName = "daily_budget", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public decimal? DailyBudget { get; set; }

        /// <summary>
        /// The effective status of the ad set, which can be either its own status or caused by its parent campaign.
        /// </summary>
        [DeserializeAs(Name = "effective_status")]
        [JsonProperty(PropertyName = "effective_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdsetEffectiveStatus? EffectiveStatus { get; set; }

        /// <summary>
        /// End time, in UTC UNIX timestamp
        /// </summary>
        [DeserializeAs(Name = "end_time")]
        [JsonProperty(PropertyName = "end_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EndTime { get; set; }

        /// <summary>
        /// The number of times this ad will show per day.
        /// </summary>
        [DeserializeAs(Name = "frequency_cap")]
        [JsonProperty(PropertyName = "frequency_cap", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? FrequencyCap { get; set; }

        /// <summary>
        /// The number of hours that will pass before resetting the frequency capping.
        /// </summary>
        [DeserializeAs(Name = "frequency_cap_reset_period")]
        [JsonProperty(PropertyName = "frequency_cap_reset_period", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? FrequencyCapResetPeriod { get; set; }

        /// <summary>
        /// An array of frequency control specs for this ad set. 
        /// </summary>
        [DeserializeAs(Name = "frequency_control_specs")]
        [JsonProperty(PropertyName = "frequency_control_specs", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdCampaignFrequencyControlSpecs> FrequencyControlSpec { get; set; }

        /// <summary>
        /// The Instagram actor id used for DCO ad on Instagram.
        /// </summary>
        [DeserializeAs(Name = "instagram_actor_id")]
        [JsonProperty(PropertyName = "instagram_actor_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? InstagramActorId { get; set; }

        /// <summary>
        /// Whether the advertiser express the intent to bid automatically. This field is not available if <see cref="BidInfo"/> or <see cref="BidAmount"/> is returned.
        /// </summary>
        [DeserializeAs(Name = "is_autobid")]
        [JsonProperty(PropertyName = "is_autobid", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsAutoBid { get; set; }

        /// <summary>
        /// Whether the advertiser express the intent to use average price pacing,
        /// </summary>
        [DeserializeAs(Name = "is_average_price_pacing")]
        [JsonProperty(PropertyName = "is_average_price_pacing", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsAveragePricePacing { get; set; }

        /// <summary>
        /// The lifetime budget of the set defined in your <see cref="AdAccount.Currency"/>.
        /// </summary>
        [DeserializeAs(Name = "lifetime_budget")]
        [JsonProperty(PropertyName = "lifetime_budget", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public decimal? LifetimeBudget { get; set; }

        /// <summary>
        /// Lifetime frequency cap
        /// </summary>
        [DeserializeAs(Name = "lifetime_frequency_cap")]
        [JsonProperty(PropertyName = "lifetime_frequency_cap", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? LifetimeFrequencyCap { get; set; }

        /// <summary>
        /// Lifetime impressions. Available only for campaigns with <see cref="BuyingType.FIXED_CPM"/>
        /// </summary>
        [DeserializeAs(Name = "lifetime_imps")]
        [JsonProperty(PropertyName = "lifetime_imps", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? LifetimeImpressions { get; set; }

        /// <summary>
        /// Name of ad set
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Which optimization goal this ad set is using
        /// </summary>
        [DeserializeAs(Name = "optimization_goal")]
        [JsonProperty(PropertyName = "optimization_goal", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public OptimizationGoal? OptimizationGoal { get; set; }

        /// <summary>
        /// Defines the pacing type, standard or using ad scheduling
        /// </summary>
        [DeserializeAs(Name = "pacing_type")]
        [JsonProperty(PropertyName = "pacing_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> PacingType { get; set; }

        /// <summary>
        /// The object this ad set is promoting across all its ads
        /// </summary>
        [DeserializeAs(Name = "promoted_object")]
        [JsonProperty(PropertyName = "promoted_object", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PromotedObject { get; set; }

        /// <summary>
        /// If there are recommendations for this ad set, this field includes them. Otherwise, will not be included in the response. 
        /// <para>(This field is not included in redownload mode.)</para>
        /// </summary>
        [DeserializeAs(Name = "recommendations")]
        [JsonProperty(PropertyName = "recommendations", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdRecommendation> Recommendations { get; set; }

        /// <summary>
        /// If this field is true, your daily spend may be more than your daily budget while your weekly spend will not exceed 7 times your daily budget. 
        /// </summary>
        [DeserializeAs(Name = "recurring_budget_semantics")]
        [JsonProperty(PropertyName = "recurring_budget_semantics", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? RecurringBudgetSemantics { get; set; }

        /// <summary>
        /// Reach and frequency prediction ID
        /// </summary>
        [DeserializeAs(Name = "rf_prediction_id")]
        [JsonProperty(PropertyName = "rf_prediction_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? RfPredictionId { get; set; }

        /// <summary>
        /// Whether this ad set is using RTB or not
        /// </summary>
        [DeserializeAs(Name = "rtb_flag")]
        [JsonProperty(PropertyName = "rtb_flag", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? RtbFlag { get; set; }

        /// <summary>
        /// Start time, in UTC UNIX timestamp
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        [JsonProperty(PropertyName = "start_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status set at the ad set level. It can be different from the effective status due to its parent campaign. 
        /// <para>The field returns the same value as 'configured_status', and is the suggested one to use.</para>
        /// </summary>
        [DeserializeAs(Name = "status")]
        [JsonProperty(PropertyName = "status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdsetStatus? Status { get; set; }

        /// <summary>
        /// Targeting
        /// </summary>
        [DeserializeAs(Name = "targeting")]
        [JsonProperty(PropertyName = "targeting", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Targeting { get; set; }

        /// <summary>
        /// Specify ad creative that displays at custom date ranges in a campaign as an array. A list of Adgroup IDs.
        /// </summary>
        /// <example>
        /// For example display first <see cref="Ad"/> in <see cref="AdSet"/> for first date range, second <see cref="Ad"/> for second date range, and so on. You can display more than one <see cref="Ad"/> per date range by providing more than one <see cref="Ad.Id"/> per array. 
        /// For example set <see cref="TimeBasedAdRotationIdBlocks"/> to [[1], [2, 3], [1, 4]]. On the first date range show <see cref="Ad"/> 1, on the second date range show <see cref="Ad"/> 2 and ad 3 and on the last date range show <see cref="Ad"/> 1 and <see cref="Ad"/> 4. 
        /// Use with <see cref="TimeBasedAdRotationIntervals"/> to specify date ranges.
        /// </example>
        [DeserializeAs(Name = "time_based_ad_rotation_id_blocks")]
        [JsonProperty(PropertyName = "time_based_ad_rotation_id_blocks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<int> TimeBasedAdRotationIdBlocks { get; set; }

        /// <summary>
        /// Date range when specific ad creative displays during a campaign. 
        /// Provide date ranges in an array of UNIX timestamps where each timestamp represents the start time for each date range. 
        /// </summary>
        /// <example>
        /// For example a 3-day <see cref="Campaign"/> from May 9 12am to May 11 11:59PM PST can have three date ranges, the first date range starts from May 9 12:00AM to May 9 11:59PM, second date range starts from May 10 12:00AM to May 10 11:59PM and last starts from May 11 12:00AM to May 11 11:59PM. The first timestamp should match the <see cref="Campaign"/> start time. 
        /// The last timestamp should be at least 1 hour before the <see cref="Entities.Campaign.StopTime"/>. You must provide at least two date ranges. All date ranges must cover the whole campaign length, so any date range cannot exceed campaign length. Use with time_based_ad_rotation_id_blocks to specify <see cref="Creative"/> for each date range.
        /// </example>
        [DeserializeAs(Name = "time_based_ad_rotation_intervals")]
        [JsonProperty(PropertyName = "time_based_ad_rotation_intervals", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<int> TimeBasedAdRotationIntervals { get; set; }

        /// <summary>
        /// Updated time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// If set, allows Mobile App Engagement ads to optimize for <see cref="Enumerations.OptimizationGoal.LINK_CLICKS"/>
        /// </summary>
        [DeserializeAs(Name = "use_new_app_click")]
        [JsonProperty(PropertyName = "use_new_app_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsUseNewAppClick { get; set; }

        /// <summary>
        /// Get api field selectors for <see cref="AdSet"/>
        /// </summary>
        /// <param name="isIncludeCampaignFields">Set true if you wan to fetch campaign details as well</param>
        /// <returns>Comma seperated fields</returns>
        public static IList<string> GetApiSelectors(bool isIncludeCampaignFields)
        {
            var apiFields = typeof(AdSet).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null).Select(e => e.Name).ToList();


            if (!isIncludeCampaignFields) return apiFields;

            apiFields.Remove("campaign");
            apiFields.Add($"campaign.fields({string.Join(",", Campaign.GetApiSelectors())})");

            return apiFields;
        }
    }
}
