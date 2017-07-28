using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Build an audience of your customers, website visitors, mobile app visitors or people similar to them.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/custom-audience/</para>
    /// </summary>
    public class CustomAudience
    {
        /// <summary>
        /// Custom audience ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// Ad Account ID
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        public long? AccountId { get; set; }

        /// <summary>
        /// Approximate number of people in this audience
        /// </summary>
        [DeserializeAs(Name = "approximate_count")]
        public long? ApproximateCount { get; set; }

        /// <summary>
        /// JSON dictionary of type, sub_type to indicate by which method the custom audience was created.
        /// </summary>
        [DeserializeAs(Name = "data_source")]
        public CustomAudienceDataSource DataSource { get; set; }

        /// <summary>
        /// JSON dictionary of code and description. Indicates whether or not an audience can be used in ads. 
        /// </summary>
        [DeserializeAs(Name = "delivery_status")]
        public CustomAudienceStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Custom audience description
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Read-only JSON dictionary with key id containing the pixel id whose traffic generated this custom audience
        /// </summary>
        [DeserializeAs(Name = "external_event_source")]
        public AdsPixel ExternalEventSource { get; set; }

        /// <summary>
        /// Whether the audience is used to seed value based lookalike
        /// </summary>
        [DeserializeAs(Name = "is_value_based")]
        public bool? IsValueBased { get; set; }

        /// <summary>
        /// The IDs of the lookalike audiences generated from this audience
        /// </summary>
        [DeserializeAs(Name = "lookalike_audience_ids")]
        public List<long> LookalikeAudiencecIds { get; set; }

        /// <summary>
        /// Generated only when the subtype is LOOKALIKE. 
        /// </summary>
        [DeserializeAs(Name = "lookalike_spec")]
        public LookalikeSpec LookalikeSpec { get; set; }

        /// <summary>
        /// Generated only when the subtype is LOOKALIKE. 
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// JSON dictionary of code to int value and description to a description string.
        /// </summary>
        [DeserializeAs(Name = "operation_status")]
        public CustomAudienceStatus OperationStatus { get; set; }

        /// <summary>
        /// Your opt-out URL so people can choose not to be targeted
        /// </summary>
        [DeserializeAs(Name = "opt_out_link")]
        public string OptOutLink { get; set; }

        /// <summary>
        /// JSON dictionary of permissions (string) to boolean value if the custom audience has that permission
        /// </summary>
        [DeserializeAs(Name = "permission_for_actions")]
        public CustomAudiencePermission PermssionForActions { get; set; }

        /// <summary>
        /// ID of the pixel which is collecting events for this Website Custom audience
        /// </summary>
        [DeserializeAs(Name = "pixel_id")]
        public long? PixelId { get; set; }

        /// <summary>
        /// Number of days to keep the user in this cluster. You can use any value between 1 and 365 days. Defaults to forever if not specified
        /// </summary>
        [DeserializeAs(Name = "retention_days")]
        public long? RetentionDays { get; set; }

        /// <summary>
        /// Audience rules to be applied on the referrer URL
        /// </summary>
        [DeserializeAs(Name = "rule")]
        public string Rule { get; set; }

        /// <summary>
        /// Aggregation on top of the rule, examples of aggregations include: count, sum etc
        /// </summary>
        [DeserializeAs(Name = "rule_aggregation")]
        public string RuleAggrigation { get; set; }

        /// <summary>
        /// Type of custom audience, derived from original data source
        /// </summary>
        [DeserializeAs(Name = "subtype")]
        public string Subtype { get; set; }

        /// <summary>
        /// Last update of people in this custom audience
        /// </summary>
        [DeserializeAs(Name = "time_content_updated")]
        public string TimeContentUpdated { get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [DeserializeAs(Name = "time_created")]
        public string TimeCreated { get; set; }

        /// <summary>
        /// Last time this audience metadata was updated
        /// </summary>
        [DeserializeAs(Name = "time_updated")]
        public string TimeUpdated { get; set; }



        /// <summary>
        /// Get api field selectors for <see cref="CustomAudience"/>
        /// </summary>
        /// <returns>Comma seperated fields</returns>
        public static string GetSelectors()
        {
            var selectors = new string[]
            {
                "id", "accoint_id", "approximate_count", "data_source", "delivery_status", "description",
                "external_event_source", "is_value_based", "lookalike_audience_ids", "lookalike_spec", "name",
                "operation_status", "opt_out_link", "permission_for_actions", "pixel_id", "retention_days", "rule",
                "rule_aggregation", "subtype", "time_content_updated", "time_created", "time_updated"
            };

            return string.Join(",", selectors);
        }
    }
}
