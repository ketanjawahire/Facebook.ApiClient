using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents page leadgen form
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_forms/</para>
    /// </summary>
    public class LeadgenForm
    {
        /// <summary>
        /// Form id
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// Form created time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// User who created this form
        /// </summary>
        [DeserializeAs(Name = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Expired leads count
        /// </summary>
        [DeserializeAs(Name = "expired_leads_count")]
        public long? ExpiredLeadsCount { get; set; }

        /// <summary>
        /// Count of leads collected
        /// </summary>
        [DeserializeAs(Name = "leads_count")]
        public long? LeadsCount { get; set; }

        /// <summary>
        /// Follow up action text
        /// </summary>
        [DeserializeAs(Name = "follow_up_action_text")]
        public string FollowUpActionText { get; set; }

        /// <summary>
        /// Leadgen export CSV url
        /// </summary>
        [DeserializeAs(Name = "leadgen_export_csv_url")]
        public string LeadgenExportCsvUrl { get; set; }

        /// <summary>
        /// Organic lead count
        /// </summary>
        [DeserializeAs(Name = "organic_leads_count")]
        public long? OrganicLeadsCount { get; set; }

        /// <summary>
        /// Form status
        /// </summary>
        [DeserializeAs(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Qualifiers
        /// </summary>
        [DeserializeAs(Name = "qualifiers")]
        public string Qualifiers { get; set; }

        /// <summary>
        /// Page id
        /// </summary>
        [DeserializeAs(Name = "page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// Page object
        /// </summary>
        [DeserializeAs(Name = "page")]
        public Page Page { get; set; }

        /// <summary>
        /// TCPA Compliance
        /// </summary>
        [DeserializeAs(Name = "tcpa_compliance")]
        public bool? IsTcpaCompliance { get; set; }

        /// <summary>
        /// Messanger welcome message
        /// </summary>
        [DeserializeAs(Name = "messenger_welcome_message")]
        public string MessengerWelcomeMessage { get; set; }

        /// <summary>
        /// Is continued flow
        /// </summary>
        [DeserializeAs(Name = "is_continued_flow")]
        public bool? IsContinuedFlow { get; set; }

        /// <summary>
        /// Creator user id
        /// </summary>
        [DeserializeAs(Name = "creator_id")]
        public long? CreatorId { get; set; }

        /// <summary>
        /// This flag controls whether leads can be submitted for this form in a non-Ad context. Default value: true
        /// </summary>
        [DeserializeAs(Name = "allow_organic_lead")]
        public bool IsAllowOrganicLead { get; set; }

        /// <summary>
        /// Whether to make the organic post invisible to viewers in non-Ad context
        /// </summary>
        [DeserializeAs(Name = "block_display_for_non_targeted_viewer")]
        public bool IsBlockDisplayForNonTargetedViewer { get; set; }

        /// <summary>
        /// Optional context card shown as the intro page
        /// </summary>
        [DeserializeAs(Name = "context_card")]
        public LeadgenContextCard ContextCard { get; set; }

        /// <summary>
        /// The final destination URL that user will go to when clicking view website button
        /// </summary>
        [DeserializeAs(Name = "follow_up_action_url")]
        public string FollowUpActionUrl { get; set; }

        /// <summary>
        /// ID of EntLeadGenLegalContent
        /// </summary>
        [DeserializeAs(Name = "legal_content")]
        public string LeagalContent { get; set; }
        
        /// <summary>
        /// The locale of the form. Pre-defined questions renders in this locale
        /// </summary>
        [DeserializeAs(Name = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// The name that will help identity the form
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The url and link_text of the privacy policy of advertiser
        /// </summary>
        [DeserializeAs(Name = "privacy_policy_url")]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// An array of questions of the form
        /// </summary>
        [DeserializeAs(Name = "questions")]
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
