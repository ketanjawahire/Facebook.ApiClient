using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents lead for leadgen form
    /// </summary>
    public class LeadgenFormLead
    {
        /// <summary>
        /// Ad name
        /// </summary>
        [DeserializeAs(Name = "ad_name")]
        public string AdName { get; set; }

        /// <summary>
        /// Adset id
        /// </summary>
        [DeserializeAs(Name = "adset_id")]
        public long? AdsetId { get; set; }
        
        /// <summary>
        /// Campaign name
        /// </summary>
        [DeserializeAs(Name = "campaign_name")]
        public string CampaignName { get; set; }

        /// <summary>
        /// Campaign id
        /// </summary>
        [DeserializeAs(Name = "campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Form field data
        /// </summary>
        [DeserializeAs(Name = "field_data")]
        public string FieldData { get; set; }

        /// <summary>
        /// Lead id
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// Is organic lead
        /// </summary>
        [DeserializeAs(Name = "is_organic")]
        public bool? IsOrganic { get; set; }

        /// <summary>
        /// Form Id
        /// </summary>
        [DeserializeAs(Name = "form_id")]
        public long? FormId { get; set; }

        /// <summary>
        /// Custom desclaimer responses
        /// </summary>
        [DeserializeAs(Name = "custom_disclaimer_responses")]
        public string CustomDisclaimerResponses { get; set; }

        /// <summary>
        /// Lead created time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Adset name
        /// </summary>
        [DeserializeAs(Name = "adset_name")]
        public string AdsetName { get; set; }

        /// <summary>
        /// post
        /// </summary>
        [DeserializeAs(Name = "post")]
        public string Post { get; set; }

        /// <summary>
        /// Ad id
        /// </summary>
        [DeserializeAs(Name = "ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// Retailer item id
        /// </summary>
        [DeserializeAs(Name = "retailer_item_id")]
        public string RetailerItemId { get; set; }
    }
}