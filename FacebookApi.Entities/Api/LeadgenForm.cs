using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents page leadgen form
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_forms/</para>
    /// </summary>
    public class LeadgenForm : BaseEntity
    {
        /// <summary>
        /// Form id
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// Form created time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// User who created this form
        /// </summary>
        [DeserializeAs(Name = "creator")]
        [JsonProperty(PropertyName = "creator", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Creator { get; set; }

        /// <summary>
        /// Expired leads count
        /// </summary>
        [DeserializeAs(Name = "expired_leads_count")]
        [JsonProperty(PropertyName = "expired_leads_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? ExpiredLeadsCount { get; set; }

        /// <summary>
        /// Count of leads collected
        /// </summary>
        [DeserializeAs(Name = "leads_count")]
        [JsonProperty(PropertyName = "leads_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? LeadsCount { get; set; }

        /// <summary>
        /// Follow up action text
        /// </summary>
        [DeserializeAs(Name = "follow_up_action_text")]
        [JsonProperty(PropertyName = "follow_up_action_text", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FollowUpActionText { get; set; }

        /// <summary>
        /// Leadgen export CSV url
        /// </summary>
        [DeserializeAs(Name = "leadgen_export_csv_url")]
        [JsonProperty(PropertyName = "leadgen_export_csv_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LeadgenExportCsvUrl { get; set; }

        /// <summary>
        /// Organic lead count
        /// </summary>
        [DeserializeAs(Name = "organic_leads_count")]
        [JsonProperty(PropertyName = "organic_leads_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? OrganicLeadsCount { get; set; }

        /// <summary>
        /// Form status
        /// </summary>
        [DeserializeAs(Name = "status")]
        [JsonProperty(PropertyName = "status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Status { get; set; }

        /// <summary>
        /// Qualifiers
        /// </summary>
        [DeserializeAs(Name = "qualifiers")]
        [JsonProperty(PropertyName = "qualifiers", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Qualifiers { get; set; }

        /// <summary>
        /// Page id
        /// </summary>
        [DeserializeAs(Name = "page_id")]
        [JsonProperty(PropertyName = "page_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PageId { get; set; }

        /// <summary>
        /// Page object
        /// </summary>
        [DeserializeAs(Name = "page")]
        [JsonProperty(PropertyName = "page", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Page Page { get; set; }

        /// <summary>
        /// TCPA Compliance
        /// </summary>
        [DeserializeAs(Name = "tcpa_compliance")]
        [JsonProperty(PropertyName = "tcpa_compliance", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsTcpaCompliance { get; set; }

        /// <summary>
        /// Messanger welcome message
        /// </summary>
        [DeserializeAs(Name = "messenger_welcome_message")]
        [JsonProperty(PropertyName = "messenger_welcome_message", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MessengerWelcomeMessage { get; set; }

        /// <summary>
        /// Is continued flow
        /// </summary>
        [DeserializeAs(Name = "is_continued_flow")]
        [JsonProperty(PropertyName = "is_continued_flow", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsContinuedFlow { get; set; }

        /// <summary>
        /// Creator user id
        /// </summary>
        [DeserializeAs(Name = "creator_id")]
        [JsonProperty(PropertyName = "creator_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? CreatorId { get; set; }

        /// <summary>
        /// This flag controls whether leads can be submitted for this form in a non-Ad context. Default value: true
        /// </summary>
        [DeserializeAs(Name = "allow_organic_lead")]
        [JsonProperty(PropertyName = "allow_organic_lead", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsAllowOrganicLead { get; set; }

        /// <summary>
        /// Whether to make the organic post invisible to viewers in non-Ad context
        /// </summary>
        [DeserializeAs(Name = "block_display_for_non_targeted_viewer")]
        [JsonProperty(PropertyName = "block_display_for_non_targeted_viewer", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsBlockDisplayForNonTargetedViewer { get; set; }

        /// <summary>
        /// Optional context card shown as the intro page
        /// </summary>
        [DeserializeAs(Name = "context_card")]
        [JsonProperty(PropertyName = "context_card", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public LeadgenContextCard ContextCard { get; set; }

        /// <summary>
        /// The final destination URL that user will go to when clicking view website button
        /// </summary>
        [DeserializeAs(Name = "follow_up_action_url")]
        [JsonProperty(PropertyName = "follow_up_action_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FollowUpActionUrl { get; set; }

        /// <summary>
        /// ID of EntLeadGenLegalContent
        /// </summary>
        [DeserializeAs(Name = "legal_content")]
        [JsonProperty(PropertyName = "legal_content", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LeagalContent { get; set; }

        /// <summary>
        /// The locale of the form. Pre-defined questions renders in this locale
        /// </summary>
        [DeserializeAs(Name = "locale")]
        [JsonProperty(PropertyName = "locale", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Locale { get; set; }

        /// <summary>
        /// The name that will help identity the form
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// The url and link_text of the privacy policy of advertiser
        /// </summary>
        [DeserializeAs(Name = "privacy_policy_url")]
        [JsonProperty(PropertyName = "privacy_policy_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// An array of questions of the form
        /// </summary>
        [DeserializeAs(Name = "questions")]
        [JsonProperty(PropertyName = "questions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<LeadgenFormQuestions> Questions { get; set; }

        /// <summary>
        /// Get api field selectors for <see cref="LeadgenForm"/>
        /// </summary>
        /// <returns></returns>
        public static IList<string> GetApiSelectors()
        {
            var apiFields = typeof(LeadgenForm).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null).Select(e => e.Name).ToList();

            return apiFields;
        }
    }
}
