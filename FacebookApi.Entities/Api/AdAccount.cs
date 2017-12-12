using System;
using System.Collections.Generic;
using FacebookApi.Entities.Api;
using FacebookApi.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An account used to manage ads on Facebook.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-account/</para>
    /// </summary>
    public class AdAccount : BaseEntity
    {
        /// <summary>
        /// The string act_{ad_account_id}
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }

        /// <summary>
        /// Container for the ID, name, and status of the ad account groups which contain this account
        /// </summary>
        [DeserializeAs(Name = "account_groups")]
        [JsonProperty(PropertyName = "account_groups", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<AdAccountGroupResult> AccountGroups { get; set; }

        /// <summary>
        /// The ID of the ad account
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        [JsonProperty(PropertyName = "account_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long AccountId { get; set; }

        /// <summary>
        /// Status of the account 
        /// </summary>
        [DeserializeAs(Name = "account_status")]
        [JsonProperty(PropertyName = "account_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdAccountStatus AccountStatus { get; set; }

        /// <summary>
        /// Amount of time the ad account has been open, in days
        /// </summary>
        [DeserializeAs(Name = "age")]
        [JsonProperty(PropertyName = "age", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float Age { get; set; }

        /// <summary>
        /// Details of the agency advertising on behalf of this client account, if applicable
        /// </summary>
        [DeserializeAs(Name = "agency_client_declaration")]
        [JsonProperty(PropertyName = "agency_client_declaration", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AgencyClientDeclaration AgencyClientDeclaration { get; set; }

        /// <summary>
        /// Current total amount spent by the account. This can be reset.
        /// </summary>
        [DeserializeAs(Name = "amount_spent")]
        [JsonProperty(PropertyName = "amount_spent", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long AmountSpend { get; set; }

        /// <summary>
        /// relevance score of an asset
        /// </summary>
        [DeserializeAs(Name = "asset_score")]
        [JsonProperty(PropertyName = "asset_score", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float AssetScore { get; set; }

        /// <summary>
        /// Bill amount due
        /// </summary>
        [DeserializeAs(Name = "balance")]
        [JsonProperty(PropertyName = "balance", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Balance { get; set; }

        /// <summary>
        /// The Business Manager, if this ad account is owned by one
        /// </summary>
        [DeserializeAs(Name = "business")]
        [JsonProperty(PropertyName = "business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Business Business { get; set; }

        /// <summary>
        /// City for business address
        /// </summary>
        [DeserializeAs(Name = "business_city")]
        [JsonProperty(PropertyName = "business_city", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string City { get; set; }

        /// <summary>
        /// Country code for the business address
        /// </summary>
        [DeserializeAs(Name = "business_country_code")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BusinessCountryCode { get; set; }

        /// <summary>
        /// The business name for the account
        /// </summary>
        [DeserializeAs(Name = "business_name")]
        [JsonProperty(PropertyName = "business_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BusinessName { get; set; }

        /// <summary>
        /// State abbreviation for business address
        /// </summary>
        [DeserializeAs(Name = "business_state")]
        [JsonProperty(PropertyName = "business_state", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BusinessState { get; set; }

        /// <summary>
        /// First line of the business street address for the account
        /// </summary>
        [DeserializeAs(Name = "business_street")]
        [JsonProperty(PropertyName = "business_street", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BusinessStreet { get; set; }

        /// <summary>
        /// Second line of the business street address for the account
        /// </summary>
        [DeserializeAs(Name = "business_street2")]
        [JsonProperty(PropertyName = "business_street2", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BusinessStreet2 { get; set; }

        /// <summary>
        /// Zip code for business address
        /// </summary>
        [DeserializeAs(Name = "business_zip")]
        [JsonProperty(PropertyName = "business_zip", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BusinessZip { get; set; }

        /// <summary>
        /// If we can create a new automated brand lift study under the ad account.
        /// </summary>
        [DeserializeAs(Name = "can_create_brand_lift_study")]
        [JsonProperty(PropertyName = "can_create_brand_lift_study", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool CanCreateBrandLiftStudy { get; set; }

        /// <summary>
        /// Ad Account capabilities
        /// </summary>
        [DeserializeAs(Name = "capabilities")]
        [JsonProperty(PropertyName = "capabilities", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<string> Capabilities { get; set; }

        /// <summary>
        /// The time the account was created in ISO 8601 format.
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The currency used for the account, based on the corresponding value in the account settings.
        /// </summary>
        [DeserializeAs(Name = "currency")]
        [JsonProperty(PropertyName = "currency", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Currency { get; set; }

        /// <summary>
        /// The reason why the account was disabled.
        /// </summary>
        [DeserializeAs(Name = "disable_reason")]
        [JsonProperty(PropertyName = "disable_reason", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AddAccountDisableReason DisableReason { get; set; }

        /// <summary>
        /// The ID of a Facebook Page or Facebook App
        /// </summary>
        [DeserializeAs(Name = "end_advertiser")]
        [JsonProperty(PropertyName = "end_advertiser", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long EndAdvertiser { get; set; }

        /// <summary>
        /// The name of a Facebook Page or Facebook App
        /// </summary>
        [DeserializeAs(Name = "end_advertiser_name")]
        [JsonProperty(PropertyName = "end_advertiser_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EndAdvertiserName { get; set; }

        /// <summary>
        /// Failed delivery checks
        /// </summary>
        [DeserializeAs(Name = "failed_delivery_checks")]
        [JsonProperty(PropertyName = "failed_delivery_checks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<DeliveryCheck> FailedDeliveryChecks { get; set; }

        /// <summary>
        /// ID of the payment method.
        /// </summary>
        [DeserializeAs(Name = "funding_source")]
        [JsonProperty(PropertyName = "funding_source", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long FundingSource { get; set; }

        /// <summary>
        /// Funding Source Details
        /// </summary>
        [DeserializeAs(Name = "funding_source_details")]
        [JsonProperty(PropertyName = "funding_source_details", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public FundingSourceDetails FundingSourceDetails { get; set; }

        /// <summary>
        /// Whether this account has migrated permissions
        /// </summary>
        [DeserializeAs(Name = "has_migrated_permissions")]
        [JsonProperty(PropertyName = "has_migrated_permissions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool HasMigratedPermissions { get; set; }

        /// <summary>
        /// The IO number
        /// </summary>
        [DeserializeAs(Name = "io_number")]
        [JsonProperty(PropertyName = "io_number", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long IONumber { get; set; }

        /// <summary>
        /// Get the notifications status of the user for this ad account. 
        /// </summary>
        [DeserializeAs(Name = "is_notifications_enabled")]
        [JsonProperty(PropertyName = "is_notifications_enabled", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsNotificationEnabled { get; set; }

        /// <summary>
        /// Indicates that this ad account is being used for private, non-business purposes which affects how value added tax (VAT) is assessed.
        /// </summary>
        [DeserializeAs(Name = "is_personal")]
        [JsonProperty(PropertyName = "is_personal", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int IsPersonal { get; set; }

        /// <summary>
        /// If this ad account is a prepay or postpay account
        /// </summary>
        [DeserializeAs(Name = "is_prepay_account")]
        [JsonProperty(PropertyName = "is_prepay_account", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsPrepayAccount { get; set; }

        /// <summary>
        /// If tax id for this ad account is required or not
        /// </summary>
        [DeserializeAs(Name = "is_tax_id_required")]
        [JsonProperty(PropertyName = "is_tax_id_required", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsTaxIdRequired { get; set; }

        /// <summary>
        /// last used time of this object by the current viewer
        /// </summary>
        [DeserializeAs(Name = "last_used_time")]
        [JsonProperty(PropertyName = "last_used_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime LastUsedTime { get; set; }

        /// <summary>
        /// The line numbers
        /// </summary>
        [DeserializeAs(Name = "line_numbers")]
        [JsonProperty(PropertyName = "line_numbers", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<int> LineNumbers { get; set; }

        /// <summary>
        /// The ID of a Facebook Page or Facebook Application
        /// </summary>
        [DeserializeAs(Name = "media_agency")]
        [JsonProperty(PropertyName = "media_agency", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long MediaAgency { get; set; }

        /// <summary>
        /// The minimum required spend cap of campaign group
        /// </summary>
        [DeserializeAs(Name = "min_campaign_group_spend_cap")]
        [JsonProperty(PropertyName = "min_campaign_group_spend_cap", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? MinCampaignGroupSpendCap { get; set; }

        /// <summary>
        /// The minimum daily budget for this ad account
        /// </summary>
        [DeserializeAs(Name = "min_daily_budget")]
        [JsonProperty(PropertyName = "min_daily_budget", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? MinDailyBudget { get; set; }

        /// <summary>
        /// Name of the account.
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the offsite pixel Terms Of Service contract was signed.
        /// </summary>
        [DeserializeAs(Name = "offsite_pixels_tos_accepted")]
        [JsonProperty(PropertyName = "offsite_pixels_tos_accepted", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool OffsitePixelsTosAccepted { get; set; }

        /// <summary>
        /// The ID of the account owner
        /// </summary>
        [DeserializeAs(Name = "owner")]
        [JsonProperty(PropertyName = "owner", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Owner { get; set; }

        /// <summary>
        /// owner business of this object
        /// </summary>
        [DeserializeAs(Name = "owner_business")]
        [JsonProperty(PropertyName = "owner_business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Business OwnerBusiness { get; set; }

        /// <summary>
        /// The ID of a Facebook Page or Facebook App
        /// </summary>
        [DeserializeAs(Name = "partner")]
        [JsonProperty(PropertyName = "partner", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Partner { get; set; }

        /// <summary>
        /// Reach and Frequency limits configuration.
        /// </summary>
        [DeserializeAs(Name = "rf_spec")]
        [JsonProperty(PropertyName = "rf_spec", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public ReachFrequencySpec ReachFrequencySpec { get; set; }

        /// <summary>
        /// The maximum that can be spent by this account after which campaigns will be paused.
        /// </summary>
        [DeserializeAs(Name = "spend_cap")]
        [JsonProperty(PropertyName = "spend_cap", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? SpendCap { get; set; }

        /// <summary>
        /// Stored balance status for the ad account
        /// </summary>
        [DeserializeAs(Name = "stored_balance_status")]
        [JsonProperty(PropertyName = "stored_balance_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdAccountStoredBalanceStatus StoredBalanceStatus { get; set; }

        /// <summary>
        /// Tax ID
        /// </summary>
        [DeserializeAs(Name = "tax_id")]
        [JsonProperty(PropertyName = "tax_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TaxId { get; set; }

        /// <summary>
        /// VAT status code for the account.
        /// </summary>
        [DeserializeAs(Name = "tax_id_status")]
        [JsonProperty(PropertyName = "tax_id_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdAccountTaxIdStatus TaxIdStatus { get; set; }

        /// <summary>
        /// Type of Tax ID
        /// </summary>
        [DeserializeAs(Name = "tax_id_type")]
        [JsonProperty(PropertyName = "tax_id_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TaxIdType { get; set; }

        /// <summary>
        /// The timezone ID of this ad account.
        /// </summary>
        [DeserializeAs(Name = "timezone_id")]
        [JsonProperty(PropertyName = "timezone_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int TimezoneId { get; set; }

        /// <summary>
        /// Name for the time zone
        /// </summary>
        [DeserializeAs(Name = "timezone_name")]
        [JsonProperty(PropertyName = "timezone_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TimezoneName { get; set; }

        /// <summary>
        /// Time Zone difference from UTC
        /// </summary>
        [DeserializeAs(Name = "timezone_offset_hours_utc")]
        [JsonProperty(PropertyName = "timezone_offset_hours_utc", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float TimezoneOffsetHoursUTC { get; set; }

        /// <summary>
        /// IDs of Terms of Service contracts signed
        /// </summary>
        [DeserializeAs(Name = "tos_accepted")]
        [JsonProperty(PropertyName = "tos_accepted", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IDictionary<string,int> TOSAccepted { get; set; }

        /// <summary>
        /// Role ID of the user
        /// </summary>
        [DeserializeAs(Name = "user_role")]
        [JsonProperty(PropertyName = "user_role", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int UserRole { get; set; }

        /// <summary>
        /// Vertical name
        /// </summary>
        [DeserializeAs(Name = "vertical_name")]
        [JsonProperty(PropertyName = "vertical_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string VerticalName { get; set; }
    }
}
