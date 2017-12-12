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
    /// Ad Campaign
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-campaign-group</para>
    /// </summary>
    public class Campaign : BaseEntity
    {
        /// <summary>
        /// Campaign's ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// ID of the ad account that owns this campaign
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        [JsonProperty(PropertyName = "account_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Ad Labels associated with this campaign
        /// </summary>
        [DeserializeAs(Name = "adlabels")]
        [JsonProperty(PropertyName = "adlabels", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdLabel> AdLabels { get; set; }

        /// <summary>
        /// Buying type
        /// </summary>
        [DeserializeAs(Name = "buying_type")]
        [JsonProperty(PropertyName = "buying_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public BuyingType? BuyingType { get; set; }

        /// <summary>
        /// Whether the campaign can set the spend cap
        /// </summary>
        [DeserializeAs(Name = "can_use_spend_cap")]
        [JsonProperty(PropertyName = "can_use_spend_cap", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? CanUseSpendCap { get; set; }

        /// <summary>
        /// Campaign configured status
        /// </summary>
        [DeserializeAs(Name = "configured_status")]
        [JsonProperty(PropertyName = "configured_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CampaignConfiguredStatus? ConfiguredStatus { get; set; }

        /// <summary>
        /// Created Time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The effective status of this campaign.
        /// </summary>
        [DeserializeAs(Name = "effective_status")]
        [JsonProperty(PropertyName = "effective_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CampaignEffectiveStatus? EffectiveStatus { get; set; }

        /// <summary>
        /// Campaign's name
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Campaign's objective
        /// </summary>
        [DeserializeAs(Name = "objective")]
        [JsonProperty(PropertyName = "objective", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CampaignObjective? Objective { get; set; }

        /// <summary>
        /// If there are recommendations for this campaign, this field includes them. 
        /// </summary>
        [DeserializeAs(Name = "recommendations")]
        [JsonProperty(PropertyName = "recommendations", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdRecommendation> Recommendations { get; set; }

        /// <summary>
        /// A spend cap for the campaign
        /// </summary>
        [DeserializeAs(Name = "spend_cap")]
        [JsonProperty(PropertyName = "spend_cap", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? SpendCap { get; set; }

        /// <summary>
        /// Start Time
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        [JsonProperty(PropertyName = "start_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Campaign status
        /// </summary>
        [DeserializeAs(Name = "status")]
        [JsonProperty(PropertyName = "status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CampaignStatus? Status { get; set; }

        /// <summary>
        /// Stop Time
        /// </summary>
        [DeserializeAs(Name = "stop_time")]
        [JsonProperty(PropertyName = "stop_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string StopTime { get; set; }

        /// <summary>
        /// Updated Time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// Get api field selectors for <see cref="Campaign"/>
        /// </summary>
        /// <returns>Comma seperated fields</returns>
        public static IList<string> GetApiSelectors()
        {
            var apiFields = typeof(Campaign).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null).Select(e => e.Name);

            return apiFields.ToList();
        }

    }
}
