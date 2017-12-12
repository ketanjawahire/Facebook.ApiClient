using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Build an audience of your customers, website visitors, mobile app visitors or people similar to them.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/custom-audience/</para>
    /// </summary>
    public class CustomAudience : BaseEntity
    {
        /// <summary>
        /// Custom audience ID
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
        /// Approximate number of people in this audience
        /// </summary>
        [DeserializeAs(Name = "approximate_count")]
        [JsonProperty(PropertyName = "approximate_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? ApproximateCount { get; set; }

        /// <summary>
        /// JSON dictionary of type, sub_type to indicate by which method the custom audience was created.
        /// </summary>
        [DeserializeAs(Name = "data_source")]
        [JsonProperty(PropertyName = "data_source", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CustomAudienceDataSource DataSource { get; set; }

        /// <summary>
        /// JSON dictionary of code and description. Indicates whether or not an audience can be used in ads. 
        /// </summary>
        [DeserializeAs(Name = "delivery_status")]
        [JsonProperty(PropertyName = "delivery_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CustomAudienceStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Custom audience description
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// Read-only JSON dictionary with key id containing the pixel id whose traffic generated this custom audience
        /// </summary>
        [DeserializeAs(Name = "external_event_source")]
        [JsonProperty(PropertyName = "external_event_source", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdsPixel ExternalEventSource { get; set; }

        /// <summary>
        /// Whether the audience is used to seed value based lookalike
        /// </summary>
        [DeserializeAs(Name = "is_value_based")]
        [JsonProperty(PropertyName = "is_value_based", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsValueBased { get; set; }

        /// <summary>
        /// The IDs of the lookalike audiences generated from this audience
        /// </summary>
        [DeserializeAs(Name = "lookalike_audience_ids")]
        [JsonProperty(PropertyName = "lookalike_audience_ids", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<long> LookalikeAudiencecIds { get; set; }

        /// <summary>
        /// Generated only when the subtype is LOOKALIKE. 
        /// </summary>
        [DeserializeAs(Name = "lookalike_spec")]
        [JsonProperty(PropertyName = "lookalike_spec", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public LookalikeSpec LookalikeSpec { get; set; }

        /// <summary>
        /// Generated only when the subtype is LOOKALIKE. 
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// JSON dictionary of code to int value and description to a description string.
        /// </summary>
        [DeserializeAs(Name = "operation_status")]
        [JsonProperty(PropertyName = "operation_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CustomAudienceStatus OperationStatus { get; set; }

        /// <summary>
        /// Your opt-out URL so people can choose not to be targeted
        /// </summary>
        [DeserializeAs(Name = "opt_out_link")]
        [JsonProperty(PropertyName = "opt_out_link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string OptOutLink { get; set; }

        /// <summary>
        /// JSON dictionary of permissions (string) to boolean value if the custom audience has that permission
        /// </summary>
        [DeserializeAs(Name = "permission_for_actions")]
        [JsonProperty(PropertyName = "permission_for_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CustomAudiencePermission PermssionForActions { get; set; }

        /// <summary>
        /// ID of the pixel which is collecting events for this Website Custom audience
        /// </summary>
        [DeserializeAs(Name = "pixel_id")]
        [JsonProperty(PropertyName = "pixel_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? PixelId { get; set; }

        /// <summary>
        /// Number of days to keep the user in this cluster. You can use any value between 1 and 365 days. Defaults to forever if not specified
        /// </summary>
        [DeserializeAs(Name = "retention_days")]
        [JsonProperty(PropertyName = "retention_days", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? RetentionDays { get; set; }

        /// <summary>
        /// Audience rules to be applied on the referrer URL
        /// </summary>
        [DeserializeAs(Name = "rule")]
        [JsonProperty(PropertyName = "rule", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Rule { get; set; }

        /// <summary>
        /// Aggregation on top of the rule, examples of aggregations include: count, sum etc
        /// </summary>
        [DeserializeAs(Name = "rule_aggregation")]
        [JsonProperty(PropertyName = "rule_aggregation", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string RuleAggrigation { get; set; }

        /// <summary>
        /// Type of custom audience, derived from original data source
        /// </summary>
        [DeserializeAs(Name = "subtype")]
        [JsonProperty(PropertyName = "subtype", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Subtype { get; set; }

        /// <summary>
        /// Last update of people in this custom audience
        /// </summary>
        [DeserializeAs(Name = "time_content_updated")]
        [JsonProperty(PropertyName = "time_content_updated", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TimeContentUpdated { get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [DeserializeAs(Name = "time_created")]
        [JsonProperty(PropertyName = "time_created", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TimeCreated { get; set; }

        /// <summary>
        /// Last time this audience metadata was updated
        /// </summary>
        [DeserializeAs(Name = "time_updated")]
        [JsonProperty(PropertyName = "time_updated", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TimeUpdated { get; set; }



        /// <summary>
        /// Get api field selectors for <see cref="CustomAudience"/>
        /// </summary>
        /// <returns>Comma seperated fields</returns>
        public static IList<string> GetSelectors()
        {

            var apiFields = typeof(CustomAudience).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null).Select(e => e.Name).ToList();

            return apiFields;
        }
    }
}
