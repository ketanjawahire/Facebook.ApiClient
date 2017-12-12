using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents lead for leadgen form
    /// </summary>
    public class LeadgenFormLead : BaseEntity
    {
        /// <summary>
        /// Ad name
        /// </summary>
        [DeserializeAs(Name = "ad_name")]
        [JsonProperty(PropertyName = "ad_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdName { get; set; }

        /// <summary>
        /// Adset id
        /// </summary>
        [DeserializeAs(Name = "adset_id")]
        [JsonProperty(PropertyName = "adset_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? AdsetId { get; set; }

        /// <summary>
        /// Campaign name
        /// </summary>
        [DeserializeAs(Name = "campaign_name")]
        [JsonProperty(PropertyName = "campaign_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Campaign id
        /// </summary>
        [DeserializeAs(Name = "campaign_id")]
        [JsonProperty(PropertyName = "campaign_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Form field data
        /// </summary>
        [DeserializeAs(Name = "field_data")]
        [JsonProperty(PropertyName = "field_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FieldData { get; set; }

        /// <summary>
        /// Lead id
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// Is organic lead
        /// </summary>
        [DeserializeAs(Name = "is_organic")]
        [JsonProperty(PropertyName = "is_organic", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsOrganic { get; set; }

        /// <summary>
        /// Form Id
        /// </summary>
        [DeserializeAs(Name = "form_id")]
        [JsonProperty(PropertyName = "form_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? FormId { get; set; }

        /// <summary>
        /// Custom desclaimer responses
        /// </summary>
        [DeserializeAs(Name = "custom_disclaimer_responses")]
        [JsonProperty(PropertyName = "custom_disclaimer_responses", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CustomDisclaimerResponses { get; set; }

        /// <summary>
        /// Lead created time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Adset name
        /// </summary>
        [DeserializeAs(Name = "adset_name")]
        [JsonProperty(PropertyName = "adset_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdsetName { get; set; }

        /// <summary>
        /// post
        /// </summary>
        [DeserializeAs(Name = "post")]
        [JsonProperty(PropertyName = "post", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Post { get; set; }

        /// <summary>
        /// Ad id
        /// </summary>
        [DeserializeAs(Name = "ad_id")]
        [JsonProperty(PropertyName = "ad_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdId { get; set; }

        /// <summary>
        /// Retailer item id
        /// </summary>
        [DeserializeAs(Name = "retailer_item_id")]
        [JsonProperty(PropertyName = "retailer_item_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string RetailerItemId { get; set; }
    }
}
