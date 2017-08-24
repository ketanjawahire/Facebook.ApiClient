namespace FacebookApi.Entities.Enumerations
{
    /// <summary>
    /// Custom Audience subtype
    /// </summary>
    public enum CustomAudienceDataSourceSubType
    {
        /// <summary>
        /// Research poll, experiment, etc
        /// </summary>
        ANYTHING,

        /// <summary>
        /// Folder
        /// </summary>
        NOTHING,

        /// <summary>
        /// Email hashes or phone hashes
        /// </summary>
        HASHES,

        /// <summary>
        /// Facebook user ids
        /// </summary>
        USER_IDS,

        /// <summary>
        /// Email/phone hashes or user ids
        /// </summary>
        HASHES_OR_USER_IDS,

        /// <summary>
        /// Platform IDs or IDFAs
        /// </summary>
        MOBILE_ADVERTISER_IDS,

        /// <summary>
        /// Including legacy tokens
        /// </summary>
        EXTERNAL_IDS,

        /// <summary>
        /// Created from multiple types of hashes at the same time
        /// </summary>
        MULTI_HASHES,

        /// <summary>
        /// TOKENS
        /// </summary>
        TOKENS,

        /// <summary>
        /// EXTERNAL_IDS_MIX
        /// </summary>
        EXTERNAL_IDS_MIX,

        /// <summary>
        /// HOUSEHOLD_EXPANSION
        /// </summary>
        HOUSEHOLD_EXPANSION,



        /// <summary>
        /// Events reported by Facebook pixels on websites
        /// </summary>
        WEB_PIXEL_HITS,

        /// <summary>
        /// Events reported on mobile platforms
        /// </summary>
        MOBILE_APP_EVENTS,

        /// <summary>
        /// A composite audience from one or more inclusion and exclusion audiences, e.g. people who performed two or more tracked actions inside the app.
        /// </summary>
        MOBILE_APP_COMBINATION_EVENTS,

        /// <summary>
        /// Reports from video views, e.g. 3% or 95% of video has been watched
        /// </summary>
        VIDEO_EVENTS,

        /// <summary>
        /// A composite audience of one or more inclusion and exclusion audiences, e.g. an audience of people who have viewed the homepage but not completed the sign up process.
        /// </summary>
        WEB_PIXEL_COMBINATION_EVENTS,
        /// <summary>
        /// PLATFORM
        /// </summary>
        PLATFORM,

        /// <summary>
        /// ENGAGEMENT_EVENT_USERS
        /// </summary>
        ENGAGEMENT_EVENT_USERS,



        /// <summary>
        /// Created from user ids
        /// </summary>
        CUSTOM_AUDIENCE_USERS,

        /// <summary>
        /// Created from page fans
        /// </summary>
        PAGE_FANS,

        /// <summary>
        /// Created from conversions tracked by Facebook's pixel
        /// </summary>
        CONVERSION_PIXEL_HITS,

        /// <summary>
        /// Users from the mobile app
        /// </summary>
        APP_USERS,

        /// <summary>
        /// Created from a saved target group
        /// </summary>
        S_EXPR,

        /// <summary>
        /// DYNAMIC_RULE
        /// </summary>
        DYNAMIC_RULE,

        /// <summary>
        /// CAMPAIGN_CONVERSIONS
        /// </summary>
        CAMPAIGN_CONVERSIONS,

        /// <summary>
        /// WEB_PIXEL_HITS_CUSTOM_AUDIENCE_USERS
        /// </summary>
        WEB_PIXEL_HITS_CUSTOM_AUDIENCE_USERS,

        /// <summary>
        /// MOBILE_APP_CUSTOM_AUDIENCE_USERS
        /// </summary>
        MOBILE_APP_CUSTOM_AUDIENCE_USERS,

        /// <summary>
        /// COMBINATION_CUSTOM_AUDIENCE_USERS
        /// </summary>
        COMBINATION_CUSTOM_AUDIENCE_USERS,

        /// <summary>
        /// VIDEO_EVENT_USERS
        /// </summary>
        VIDEO_EVENT_USERS,

        /// <summary>
        /// FB_PIXEL_HITS
        /// </summary>
        FB_PIXEL_HITS,

        /// <summary>
        /// IG_PROMOTED_POST
        /// </summary>
        IG_PROMOTED_POST,

        /// <summary>
        /// PLACE_VISITS
        /// </summary>
        PLACE_VISITS,

        /// <summary>
        /// OFFLINE_EVENT_USERS
        /// </summary>
        OFFLINE_EVENT_USERS,

        /// <summary>
        /// EXPANDED_AUDIENCE
        /// </summary>
        EXPANDED_AUDIENCE,

        /// <summary>
        /// SEED_LIST
        /// </summary>
        SEED_LIST,

        /// <summary>
        /// PARTNER_CATEGORY_USERS
        /// </summary>
        PARTNER_CATEGORY_USERS,

        /// <summary>
        /// PAGE_SMART_AUDIENCE
        /// </summary>
        PAGE_SMART_AUDIENCE,

        /// <summary>
        /// MULTICOUNTRY_COMBINATION
        /// </summary>
        MULTICOUNTRY_COMBINATION,

        /// <summary>
        /// PLATFORM_USERS
        /// </summary>
        PLATFORM_USERS,



        /// <summary>
        /// Created from emails imported from Mailchimp
        /// </summary>
        MAIL_CHIMP_EMAIL_HASHES,

        /// <summary>
        /// Created from emails imported from Constant Contact
        /// </summary>
        CONSTANT_CONTACTS_EMAIL_HASHES,

        /// <summary>
        /// Emails entered manually via Ads Manager
        /// </summary>
        COPY_PASTE_EMAIL_HASHES,

        /// <summary>
        /// Get in touch with the importer
        /// </summary>
        CONTACT_IMPORTER,

        /// <summary>
        /// CUSTOM
        /// </summary>
        CUSTOM,

        /// <summary>
        /// 
        /// </summary>
        LOOKALIKE
    }
}
