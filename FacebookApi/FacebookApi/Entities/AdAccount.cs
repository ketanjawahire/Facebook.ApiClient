using System;
using System.Collections.Generic;
using FacebookApi.Enums;
using FacebookApi.Enums.Api;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An account used to manage ads on Facebook.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-account/</para>
    /// </summary>
    public class AdAccount
    {
        /// <summary>
        /// The string act_{ad_account_id}
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Container for the ID, name, and status of the ad account groups which contain this account
        /// </summary>
        [DeserializeAs(Name = "account_groups")]
        public IList<AdAccountGroupResult> AccountGroups { get; set; }

        /// <summary>
        /// The ID of the ad account
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Status of the account 
        /// </summary>
        [DeserializeAs(Name = "account_status")]
        public AdAccountStatus AccountStatus { get; set; }

        /// <summary>
        /// Amount of time the ad account has been open, in days
        /// </summary>
        [DeserializeAs(Name = "age")]
        public float Age { get; set; }

        /// <summary>
        /// Details of the agency advertising on behalf of this client account, if applicable
        /// </summary>
        [DeserializeAs(Name = "agency_client_declaration")]
        public AgencyClientDeclaration AgencyClientDeclaration { get; set; }

        /// <summary>
        /// Current total amount spent by the account. This can be reset.
        /// </summary>
        [DeserializeAs(Name = "amount_spent")]
        public long AmountSpend { get; set; }

        /// <summary>
        /// relevance score of an asset
        /// </summary>
        [DeserializeAs(Name = "asset_score")]
        public float AssetScore { get; set; }

        /// <summary>
        /// Bill amount due
        /// </summary>
        [DeserializeAs(Name = "balance")]
        public long Balance { get; set; }

        /// <summary>
        /// The Business Manager, if this ad account is owned by one
        /// </summary>
        [DeserializeAs(Name = "business")]
        public Business Business { get; set; }

        /// <summary>
        /// City for business address
        /// </summary>
        [DeserializeAs(Name = "business_city")]
        public string City { get; set; }

        /// <summary>
        /// Country code for the business address
        /// </summary>
        [DeserializeAs(Name = "business_country_code")]
        public string BusinessCountryCode { get; set; }

        /// <summary>
        /// The business name for the account
        /// </summary>
        [DeserializeAs(Name = "business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// State abbreviation for business address
        /// </summary>
        [DeserializeAs(Name = "business_state")]
        public string BusinessState { get; set; }

        /// <summary>
        /// First line of the business street address for the account
        /// </summary>
        [DeserializeAs(Name = "business_street")]
        public string BusinessStreet { get; set; }

        /// <summary>
        /// Second line of the business street address for the account
        /// </summary>
        [DeserializeAs(Name = "business_street2")]
        public string BusinessStreet2 { get; set; }

        /// <summary>
        /// Zip code for business address
        /// </summary>
        [DeserializeAs(Name = "business_zip")]
        public string BusinessZip { get; set; }

        /// <summary>
        /// If we can create a new automated brand lift study under the ad account.
        /// </summary>
        [DeserializeAs(Name = "can_create_brand_lift_study")]
        public bool CanCreateBrandLiftStudy { get; set; }

        /// <summary>
        /// Ad Account capabilities
        /// </summary>
        [DeserializeAs(Name = "capabilities")]
        public IList<string> Capabilities { get; set; }

        /// <summary>
        /// The time the account was created in ISO 8601 format.
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The currency used for the account, based on the corresponding value in the account settings.
        /// </summary>
        [DeserializeAs(Name = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The reason why the account was disabled.
        /// </summary>
        [DeserializeAs(Name = "disable_reason")]
        public AddAccountDisableReason DisableReason { get; set; }

        /// <summary>
        /// The ID of a Facebook Page or Facebook App
        /// </summary>
        [DeserializeAs(Name = "end_advertiser")]
        public long EndAdvertiser { get; set; }

        /// <summary>
        /// The name of a Facebook Page or Facebook App
        /// </summary>
        [DeserializeAs(Name = "end_advertiser_name")]
        public string EndAdvertiserName { get; set; }

        /// <summary>
        /// Failed delivery checks
        /// </summary>
        [DeserializeAs(Name = "failed_delivery_checks")]
        public IList<DeliveryCheck> FailedDeliveryChecks { get; set; }

        /// <summary>
        /// ID of the payment method.
        /// </summary>
        [DeserializeAs(Name = "funding_source")]
        public long FundingSource { get; set; }

        /// <summary>
        /// Funding Source Details
        /// </summary>
        [DeserializeAs(Name = "funding_source_details")]
        public FundingSourceDetails FundingSourceDetails { get; set; }

        /// <summary>
        /// Whether this account has migrated permissions
        /// </summary>
        [DeserializeAs(Name = "has_migrated_permissions")]
        public bool HasMigratedPermissions { get; set; }

        /// <summary>
        /// The IO number
        /// </summary>
        [DeserializeAs(Name = "io_number")]
        public long IONumber { get; set; }

        /// <summary>
        /// Get the notifications status of the user for this ad account. 
        /// </summary>
        [DeserializeAs(Name = "is_notifications_enabled")]
        public bool IsNotificationEnabled { get; set; }

        /// <summary>
        /// Indicates that this ad account is being used for private, non-business purposes which affects how value added tax (VAT) is assessed.
        /// </summary>
        [DeserializeAs(Name = "is_personal")]
        public int IsPersonal { get; set; }

        /// <summary>
        /// If this ad account is a prepay or postpay account
        /// </summary>
        [DeserializeAs(Name = "is_prepay_account")]
        public bool IsPrepayAccount { get; set; }

        /// <summary>
        /// If tax id for this ad account is required or not
        /// </summary>
        [DeserializeAs(Name = "is_tax_id_required")]
        public bool IsTaxIdRequired { get; set; }

        /// <summary>
        /// last used time of this object by the current viewer
        /// </summary>
        [DeserializeAs(Name = "last_used_time")]
        public DateTime LastUsedTime { get; set; }

        /// <summary>
        /// The line numbers
        /// </summary>
        [DeserializeAs(Name = "line_numbers")]
        public IList<int> LineNumbers { get; set; }

        /// <summary>
        /// The ID of a Facebook Page or Facebook Application
        /// </summary>
        [DeserializeAs(Name = "media_agency")]
        public long MediaAgency { get; set; }

        /// <summary>
        /// The minimum required spend cap of campaign group
        /// </summary>
        [DeserializeAs(Name = "min_campaign_group_spend_cap")]
        public int? MinCampaignGroupSpendCap { get; set; }

        /// <summary>
        /// The minimum daily budget for this ad account
        /// </summary>
        [DeserializeAs(Name = "min_daily_budget")]
        public int? MinDailyBudget { get; set; }

        /// <summary>
        /// Name of the account.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the offsite pixel Terms Of Service contract was signed.
        /// </summary>
        [DeserializeAs(Name = "offsite_pixels_tos_accepted")]
        public bool OffsitePixelsTosAccepted { get; set; }

        /// <summary>
        /// The ID of the account owner
        /// </summary>
        [DeserializeAs(Name = "owner")]
        public long Owner { get; set; }

        /// <summary>
        /// owner business of this object
        /// </summary>
        [DeserializeAs(Name = "owner_business")]
        public Business OwnerBusiness { get; set; }

        /// <summary>
        /// The ID of a Facebook Page or Facebook App
        /// </summary>
        [DeserializeAs(Name = "partner")]
        public long Partner { get; set; }

        /// <summary>
        /// Reach and Frequency limits configuration.
        /// </summary>
        [DeserializeAs(Name = "rf_spec")]
        public ReachFrequencySpec ReachFrequencySpec { get; set; }

        /// <summary>
        /// The maximum that can be spent by this account after which campaigns will be paused.
        /// </summary>
        [DeserializeAs(Name = "spend_cap")]
        public long? SpendCap { get; set; }

        /// <summary>
        /// Stored balance status for the ad account
        /// </summary>
        [DeserializeAs(Name = "stored_balance_status")]
        public AdAccountStoredBalanceStatus StoredBalanceStatus { get; set; }

        /// <summary>
        /// Tax ID
        /// </summary>
        [DeserializeAs(Name = "tax_id")]
        public string TaxId { get; set; }

        /// <summary>
        /// VAT status code for the account.
        /// </summary>
        [DeserializeAs(Name = "tax_id_status")]
        public AdAccountTaxIdStatus TaxIdStatus { get; set; }

        /// <summary>
        /// Type of Tax ID
        /// </summary>
        [DeserializeAs(Name = "tax_id_type")]
        public string TaxIdType { get; set; }

        /// <summary>
        /// The timezone ID of this ad account.
        /// </summary>
        [DeserializeAs(Name = "timezone_id")]
        public int TimezoneId { get; set; }

        /// <summary>
        /// Name for the time zone
        /// </summary>
        [DeserializeAs(Name = "timezone_name")]
        public string TimezoneName { get; set; }

        /// <summary>
        /// Time Zone difference from UTC
        /// </summary>
        [DeserializeAs(Name = "timezone_offset_hours_utc")]
        public float TimezoneOffsetHoursUTC { get; set; }

        /// <summary>
        /// IDs of Terms of Service contracts signed
        /// </summary>
        [DeserializeAs(Name = "tos_accepted")]
        public IDictionary<string,int> TOSAccepted { get; set; }

        /// <summary>
        /// Role ID of the user
        /// </summary>
        [DeserializeAs(Name = "user_role")]
        public int UserRole { get; set; }

        /// <summary>
        /// Vertical name
        /// </summary>
        [DeserializeAs(Name = "vertical_name")]
        public string VerticalName { get; set; }
    }
}
