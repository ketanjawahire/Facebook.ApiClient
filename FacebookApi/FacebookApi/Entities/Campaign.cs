using System;
using System.Collections.Generic;
using FacebookApi.Enums;
using FacebookApi.Enums.Api;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Ad Campaign
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-campaign-group</para>
    /// </summary>
    public class Campaign 
    {
        /// <summary>
        /// Campaign's ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of the ad account that owns this campaign
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Ad Labels associated with this campaign
        /// </summary>
        [DeserializeAs(Name = "adlabels")]
        public List<AdLabel> AdLabels { get; set; }

        /// <summary>
        /// Buying type
        /// </summary>
        [DeserializeAs(Name = "buying_type")]
        public BuyingType? BuyingType { get; set; }

        /// <summary>
        /// Whether the campaign can set the spend cap
        /// </summary>
        [DeserializeAs(Name = "can_use_spend_cap")]
        public bool CanUseSpendCap { get; set; }

        /// <summary>
        /// Campaign configured status
        /// </summary>
        [DeserializeAs(Name = "configured_status")]
        public CampaignConfiguredStatus? ConfiguredStatus { get; set; }

        /// <summary>
        /// Created Time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The effective status of this campaign.
        /// </summary>
        [DeserializeAs(Name = "effective_status")]
        public CampaignEffectiveStatus? EffectiveStatus { get; set; }

        /// <summary>
        /// Campaign's name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Campaign's objective
        /// </summary>
        [DeserializeAs(Name = "objective")]
        public CampaignObjective? Objective { get; set; }

        /// <summary>
        /// If there are recommendations for this campaign, this field includes them. 
        /// </summary>
        [DeserializeAs(Name = "recommendations")]
        public List<AdRecommendation> Recommendations { get; set; }

        /// <summary>
        /// A spend cap for the campaign
        /// </summary>
        [DeserializeAs(Name = "spend_cap")]
        public int? SpendCap { get; set; }

        /// <summary>
        /// Start Time
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Campaign status
        /// </summary>
        [DeserializeAs(Name = "status")]
        public CampaignStatus? Status { get; set; }

        /// <summary>
        /// Stop Time
        /// </summary>
        [DeserializeAs(Name = "stop_time")]
        public DateTime? StopTime { get; set; }

        /// <summary>
        /// Updated Time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

        public static IList<string> GetApiSelectors()
        {
            var apiSelectors = new List<string>()
            {
                "id",
                "account_id",
                "adlabels",
                "buying_type",
                "can_use_spend_cap",
                "configured_status",
                "created_time",
                "effective_status",
                "name",
                "objective",
                "recommendations",
                "spend_cap",
                "start_time",
                "status",
                "stop_time",
                "updated_time"
            };
            return apiSelectors;
        }

    }
}
