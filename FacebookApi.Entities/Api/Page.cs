using System;
using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// This represents a Facebook Page.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/</para>
    /// </summary>
    public class Page : BaseEntity
    {
        /// <summary>
        /// Page ID. No access token is required to access this field
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Id { get; set; }

        /// <summary>
        /// Information about the Page
        /// </summary>
        [DeserializeAs(Name = "about")]
        [JsonProperty(PropertyName = "about", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string About { get; set; }

        /// <summary>
        /// The access token you can use to act as the Page. Only visible to Page Admins
        /// </summary>
        [DeserializeAs(Name = "access_token")]
        [JsonProperty(PropertyName = "access_token", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The Page's currently running promotion campaign
        /// </summary>
        [DeserializeAs(Name = "ad_campaign")]
        [JsonProperty(PropertyName = "ad_campaign", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Campaign Campaign { get; set; }

        /// <summary>
        /// Affiliation of this person. Applicable to Pages representing people
        /// </summary>
        [DeserializeAs(Name = "affiliation")]
        [JsonProperty(PropertyName = "affiliation", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Affiliation { get; set; }

        /// <summary>
        /// App ID for app-owned Pages and app Pages
        /// </summary>
        [DeserializeAs(Name = "app_id")]
        [JsonProperty(PropertyName = "app_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int AppId { get; set; }

        /// <summary>
        /// AppLinks data associated with the Page's URL
        /// </summary>
        [DeserializeAs(Name = "app_links")]
        [JsonProperty(PropertyName = "app_links", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AppLinks Applinks { get; set; }

        /// <summary>
        /// Artists the band likes. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "artists_we_like")]
        [JsonProperty(PropertyName = "artists_we_like", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ArtistsWeLike { get; set; }

        /// <summary>
        /// relevance score of an asset
        /// </summary>
        [DeserializeAs(Name = "asset_score")]
        [JsonProperty(PropertyName = "asset_score", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float? AssetScore { get; set; }

        /// <summary>
        /// Dress code of the business. Applicable to Restaurants or Nightlife. Can be one of Casual, Dressy or Unspecified
        /// </summary>
        [DeserializeAs(Name = "attire")]
        [JsonProperty(PropertyName = "attire", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Attire { get; set; }

        /// <summary>
        /// The awards information of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "awards")]
        [JsonProperty(PropertyName = "awards", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Awards { get; set; }

        /// <summary>
        /// Band interests. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "band_interests")]
        [JsonProperty(PropertyName = "band_interests", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BandInterests { get; set; }

        /// <summary>
        /// Members of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "band_members")]
        [JsonProperty(PropertyName = "band_members", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BandMembers { get; set; }

        /// <summary>
        /// The best available Page on Facebook for the concept represented by this Page
        /// </summary>
        [DeserializeAs(Name = "best_page")]
        [JsonProperty(PropertyName = "best_page", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Page BestPage { get; set; }

        /// <summary>
        /// Biography of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "bio")]
        [JsonProperty(PropertyName = "bio", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Bio { get; set; }

        /// <summary>
        /// Birthday of this person. Applicable to Pages representing people
        /// </summary>
        [DeserializeAs(Name = "birthday")]
        [JsonProperty(PropertyName = "birthday", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Birthday { get; set; }

        /// <summary>
        /// Booking agent of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "booking_agent")]
        [JsonProperty(PropertyName = "booking_agent", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BookingAgent { get; set; }

        /// <summary>
        /// Year vehicle was built. Applicable to Vehicles
        /// </summary>
        [DeserializeAs(Name = "built")]
        [JsonProperty(PropertyName = "built", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Built { get; set; }

        /// <summary>
        /// The Business associated with this Page
        /// </summary>
        [DeserializeAs(Name = "business")]
        [JsonProperty(PropertyName = "business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Business { get; set; }

        /// <summary>
        /// Whether this page has checkin functionality enabled
        /// </summary>
        [DeserializeAs(Name = "can_checkin")]
        [JsonProperty(PropertyName = "can_checkin", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool CanCheckin { get; set; }

        /// <summary>
        /// Whether the current session user can post on this Page
        /// </summary>
        [DeserializeAs(Name = "can_post")]
        [JsonProperty(PropertyName = "can_post", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool CanPost { get; set; }

        /// <summary>
        /// The Page's category. e.g. Product/Service, Computers/Technology
        /// </summary>
        [DeserializeAs(Name = "category")]
        [JsonProperty(PropertyName = "category", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Category { get; set; }

        /// <summary>
        /// The Page's sub-categories
        /// </summary>
        [DeserializeAs(Name = "category_list")]
        [JsonProperty(PropertyName = "category_list", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<PageCategory> CategoryList { get; set; }

        /// <summary>
        /// Number of checkins at a place represented by a Page
        /// </summary>
        [DeserializeAs(Name = "checkins")]
        [JsonProperty(PropertyName = "checkins", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Checkins { get; set; }

        /// <summary>
        /// The company overview. Applicable to Companies
        /// </summary>
        [DeserializeAs(Name = "company_overview")]
        [JsonProperty(PropertyName = "company_overview", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CompanyOverview { get; set; }

        /// <summary>
        /// The mailing or contact address for this page.
        /// </summary>
        [DeserializeAs(Name = "contact_address")]
        [JsonProperty(PropertyName = "contact_address", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public MailingAddress ContactAddress { get; set; }

        /// <summary>
        /// Social context for this Page
        /// </summary>
        [DeserializeAs(Name = "context")]
        [JsonProperty(PropertyName = "context", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public OpenGraphContext Context { get; set; }

        /// <summary>
        /// If this is a Page in a Global Pages hierarchy, the number of people who are being directed to this Page.
        /// </summary>
        [DeserializeAs(Name = "country_page_likes")]
        [JsonProperty(PropertyName = "country_page_likes", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CountryPageLikes { get; set; }

        /// <summary>
        /// Information about the page's cover photo
        /// </summary>
        [DeserializeAs(Name = "cover")]
        [JsonProperty(PropertyName = "cover", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CoverPhoto Cover { get; set; }

        /// <summary>
        /// Culinary team of the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "culinary_team")]
        [JsonProperty(PropertyName = "culinary_team", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CulinaryTeam { get; set; }

        /// <summary>
        /// Current location of the Page
        /// </summary>
        [DeserializeAs(Name = "current_location")]
        [JsonProperty(PropertyName = "current_location", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CurrentLocation { get; set; }

        /// <summary>
        /// The description of the Page
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// The description of the Page in raw HTML
        /// </summary>
        [DeserializeAs(Name = "description_html")]
        [JsonProperty(PropertyName = "description_html", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DescriptionHTML { get; set; }

        /// <summary>
        /// The director of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "directed_by")]
        [JsonProperty(PropertyName = "directed_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DirectedBy { get; set; }

        /// <summary>
        /// Subtext about the Page being viewed
        /// </summary>
        [DeserializeAs(Name = "display_subtext")]
        [JsonProperty(PropertyName = "display_subtext", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DisplaySubtext { get; set; }

        /// <summary>
        /// The emails listed in the About section of a Page
        /// </summary>
        [DeserializeAs(Name = "emails")]
        [JsonProperty(PropertyName = "emails", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<string> Emails { get; set; }

        /// <summary>
        /// The social sentence and like count information for this Page. This is the same info used for the like button
        /// </summary>
        [DeserializeAs(Name = "engagement")]
        [JsonProperty(PropertyName = "engagement", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Engagement Engagement { get; set; }

        /// <summary>
        /// Video Featured by the Page.
        /// </summary>
        [DeserializeAs(Name = "featured_video")]
        [JsonProperty(PropertyName = "featured_video", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Video FeaturedVideo { get; set; }

        /// <summary>
        /// Features of the vehicle. Applicable to Vehicles
        /// </summary>
        [DeserializeAs(Name = "features")]
        [JsonProperty(PropertyName = "features", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Features { get; set; }

        /// <summary>
        /// The restaurant's food styles. Applicable to Restaurants
        /// </summary>
        [DeserializeAs(Name = "food_styles")]
        [JsonProperty(PropertyName = "food_styles", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<string> FoodStyles { get; set; }

        /// <summary>
        /// When the company was founded. Applicable to Pages in the Company category
        /// </summary>
        [DeserializeAs(Name = "founded")]
        [JsonProperty(PropertyName = "founded", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Founded { get; set; }

        /// <summary>
        /// General information provided by the Page
        /// </summary>
        [DeserializeAs(Name = "general_info")]
        [JsonProperty(PropertyName = "general_info", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string GeneralInfo { get; set; }

        /// <summary>
        /// General manager of the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "general_manager")]
        [JsonProperty(PropertyName = "general_manager", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string GeneralManager { get; set; }

        /// <summary>
        /// The genre of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "genre")]
        [JsonProperty(PropertyName = "genre", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Genre { get; set; }

        /// <summary>
        /// The name of the Page with country codes appended for Global Brand Pages. Only visible to the Page admin
        /// </summary>
        [DeserializeAs(Name = "global_brand_page_name")]
        [JsonProperty(PropertyName = "global_brand_page_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string GlobalBrandPageName { get; set; }

        /// <summary>
        /// This brand's global Root ID
        /// </summary>
        [DeserializeAs(Name = "global_brand_root_id")]
        [JsonProperty(PropertyName = "global_brand_root_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? GlobalBrandRootId { get; set; }

        /// <summary>
        /// Indicates whether this Page has added the app making the query in a Page tab
        /// </summary>
        [DeserializeAs(Name = "has_added_app")]
        [JsonProperty(PropertyName = "has_added_app", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool HasAddedApp { get; set; }

        /// <summary>
        /// Hometown of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "hometown")]
        [JsonProperty(PropertyName = "hometown", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Hometown { get; set; }

        /// <summary>
        /// Indicates a single range of opening hours for a day. 
        /// </summary>
        [DeserializeAs(Name = "hours")]
        [JsonProperty(PropertyName = "hours", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IDictionary<string, string> Hours { get; set; }

        /// <summary>
        /// Legal information about the Page publishers
        /// </summary>
        [DeserializeAs(Name = "impressum")]
        [JsonProperty(PropertyName = "impressum", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Impressum { get; set; }

        /// <summary>
        /// Influences on the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "influences")]
        [JsonProperty(PropertyName = "influences", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Influences { get; set; }

        /// <summary>
        /// Indicates whether this location is always open
        /// </summary>
        [DeserializeAs(Name = "is_always_open")]
        [JsonProperty(PropertyName = "is_always_open", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsAlwaysOpen { get; set; }

        /// <summary>
        /// Indicates whether the Page is a community Page
        /// </summary>
        [DeserializeAs(Name = "is_community_page")]
        [JsonProperty(PropertyName = "is_community_page", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsCommunityPage { get; set; }

        /// <summary>
        /// Whether the business corresponding to this Page is permanently closed
        /// </summary>
        [DeserializeAs(Name = "is_permanently_closed")]
        [JsonProperty(PropertyName = "is_permanently_closed", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsPermanentlyClosed { get; set; }

        /// <summary>
        /// Indicates whether the Page is published and visible to non-admins
        /// </summary>
        [DeserializeAs(Name = "is_published")]
        [JsonProperty(PropertyName = "is_published", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Indicates whether the Page is unclaimed
        /// </summary>
        [DeserializeAs(Name = "is_unclaimed")]
        [JsonProperty(PropertyName = "is_unclaimed", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsUnclaimed { get; set; }

        /// <summary>
        /// Pages with a large number of followers can be manually verified by Facebook as having an authentic identity
        /// </summary>
        [DeserializeAs(Name = "is_verified")]
        [JsonProperty(PropertyName = "is_verified", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string IsVerified { get; set; }

        /// <summary>
        /// last used time of this object by the current viewer
        /// </summary>
        [DeserializeAs(Name = "last_used_time")]
        [JsonProperty(PropertyName = "last_used_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? LastUsedTime { get; set; }

        /// <summary>
        /// Indicates whether a user has accepted the TOS for running LeadGen Ads on the Page
        /// </summary>
        [DeserializeAs(Name = "leadgen_tos_accepted")]
        [JsonProperty(PropertyName = "leadgen_tos_accepted", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? LeadgenTOSAccepted { get; set; }

        /// <summary>
        /// The number of users who like the Page.
        /// </summary>
        [DeserializeAs(Name = "likes")]
        [JsonProperty(PropertyName = "likes", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? Likes { get; set; }

        /// <summary>
        /// The Page's Facebook URL
        /// </summary>
        [DeserializeAs(Name = "link")]
        [JsonProperty(PropertyName = "link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Link { get; set; }

        /// <summary>
        /// The location of this place. Applicable to all Places
        /// </summary>
        [DeserializeAs(Name = "location")]
        [JsonProperty(PropertyName = "location", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Location Location { get; set; }

        /// <summary>
        /// Members of this org. Applicable to Pages representing Team Orgs
        /// </summary>
        [DeserializeAs(Name = "members")]
        [JsonProperty(PropertyName = "members", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Members { get; set; }

        /// <summary>
        /// The company mission. Applicable to Companies
        /// </summary>
        [DeserializeAs(Name = "mission")]
        [JsonProperty(PropertyName = "mission", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Mission { get; set; }

        /// <summary>
        /// MPG of the vehicle. Applicable to Vehicles
        /// </summary>
        [DeserializeAs(Name = "mpg")]
        [JsonProperty(PropertyName = "mpg", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MPG { get; set; }

        /// <summary>
        /// The name of the Page
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the Page with its location and/or global brand descriptor
        /// </summary>
        [DeserializeAs(Name = "name_with_location_descriptor")]
        [JsonProperty(PropertyName = "name_with_location_descriptor", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string NameWithLocalDescriptor { get; set; }

        /// <summary>
        /// The TV network for the TV show. Applicable to TV Shows
        /// </summary>
        [DeserializeAs(Name = "network")]
        [JsonProperty(PropertyName = "network", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Network { get; set; }

        /// <summary>
        /// The number of people who have liked the Page, since the last login. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "new_like_count")]
        [JsonProperty(PropertyName = "new_like_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? NewLikeCount { get; set; }

        /// <summary>
        /// Offer eligibility status. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "offer_eligible")]
        [JsonProperty(PropertyName = "offer_eligible", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? OfferEligible { get; set; }

        /// <summary>
        /// owner business of this object
        /// </summary>
        [DeserializeAs(Name = "owner_business")]
        [JsonProperty(PropertyName = "owner_business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Business OwnerBusiness { get; set; }

        /// <summary>
        /// Parent Page for this Page
        /// </summary>
        [DeserializeAs(Name = "parent_page")]
        [JsonProperty(PropertyName = "parent_page", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Page ParentPage { get; set; }

        /// <summary>
        /// Parking information. Applicable to Businesses and Places
        /// </summary>
        [DeserializeAs(Name = "parking")]
        [JsonProperty(PropertyName = "parking", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PageParking Parking { get; set; }

        /// <summary>
        /// Payment options accepted by the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "payment_options")]
        [JsonProperty(PropertyName = "payment_options", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PagePaymentOptions PaymentOptions { get; set; }

        /// <summary>
        /// Personal information. Applicable to Pages representing People
        /// </summary>
        [DeserializeAs(Name = "personal_info")]
        [JsonProperty(PropertyName = "personal_info", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PersonalInformation { get; set; }

        /// <summary>
        /// Personal interests. Applicable to Pages representing People
        /// </summary>
        [DeserializeAs(Name = "personal_interests")]
        [JsonProperty(PropertyName = "personal_interests", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PersonalInterests { get; set; }

        /// <summary>
        /// Pharmacy safety information. Applicable to Pharmaceutical companies
        /// </summary>
        [DeserializeAs(Name = "pharma_safety_info")]
        [JsonProperty(PropertyName = "pharma_safety_info", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PharmaSafetyInformation { get; set; }

        /// <summary>
        /// Phone number provided by a Page
        /// </summary>
        [DeserializeAs(Name = "phone")]
        [JsonProperty(PropertyName = "phone", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Phone { get; set; }

        /// <summary>
        /// For places, the category of the place
        /// </summary>
        [DeserializeAs(Name = "place_type")]
        [JsonProperty(PropertyName = "place_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PlaceType { get; set; }

        /// <summary>
        /// The plot outline of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "plot_outline")]
        [JsonProperty(PropertyName = "plot_outline", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PlotOutline { get; set; }

        /// <summary>
        /// Press contact information of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "press_contact")]
        [JsonProperty(PropertyName = "press_contact", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PressContact { get; set; }

        /// <summary>
        /// Price range of the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "price_range")]
        [JsonProperty(PropertyName = "price_range", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PriceRange { get; set; }

        /// <summary>
        /// The productor of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "produced_by")]
        [JsonProperty(PropertyName = "produced_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ProducedBy { get; set; }

        /// <summary>
        /// The products of this company. Applicable to Companies
        /// </summary>
        [DeserializeAs(Name = "products")]
        [JsonProperty(PropertyName = "products", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Products { get; set; }

        /// <summary>
        /// Reason why a post isn't eligible for boosting. Only visible to Page Admins
        /// </summary>
        [DeserializeAs(Name = "promotion_eligible")]
        [JsonProperty(PropertyName = "promotion_eligible", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsPromotionEligible { get; set; }

        /// <summary>
        /// Reason, for which boosted posts are not eligible. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "promotion_ineligible_reason")]
        [JsonProperty(PropertyName = "promotion_ineligible_reason", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PromotionInEligibleReason { get; set; }

        /// <summary>
        /// Public transit to the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "public_transit")]
        [JsonProperty(PropertyName = "public_transit", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PublicTransit { get; set; }

        /// <summary>
        /// Record label of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "record_label")]
        [JsonProperty(PropertyName = "record_label", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string RecordLabel { get; set; }

        /// <summary>
        /// The film's release date. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "release_date")]
        [JsonProperty(PropertyName = "release_date", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Services the restaurant provides. Applicable to Restaurants
        /// </summary>
        [DeserializeAs(Name = "restaurant_services")]
        [JsonProperty(PropertyName = "restaurant_services", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PageRestaurantServices RestaurantServices { get; set; }

        /// <summary>
        /// The restaurant's specialties. Applicable to Restaurants
        /// </summary>
        [DeserializeAs(Name = "restaurant_specialties")]
        [JsonProperty(PropertyName = "restaurant_specialties", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PageRestaurantSpecialties RestaurantSpecialties { get; set; }

        /// <summary>
        /// The air schedule of the TV show. Applicable to TV Shows
        /// </summary>
        [DeserializeAs(Name = "schedule")]
        [JsonProperty(PropertyName = "schedule", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Schedule { get; set; }

        /// <summary>
        /// The screenwriter of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "screenplay_by")]
        [JsonProperty(PropertyName = "screenplay_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ScreenplayBy { get; set; }

        /// <summary>
        /// The season information of the TV Show. Applicable to TV Shows
        /// </summary>
        [DeserializeAs(Name = "season")]
        [JsonProperty(PropertyName = "season", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Season { get; set; }

        /// <summary>
        /// The page address, if any, in a simple single line format.
        /// </summary>
        [DeserializeAs(Name = "single_line_address")]
        [JsonProperty(PropertyName = "single_line_address", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SingleLineAddress { get; set; }

        /// <summary>
        /// The cast of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "starring")]
        [JsonProperty(PropertyName = "starring", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Starring { get; set; }

        /// <summary>
        /// Information about when the entity represented by the Page was started
        /// </summary>
        [DeserializeAs(Name = "start_info")]
        [JsonProperty(PropertyName = "start_info", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PageStartInfo StartInfo { get; set; }

        /// <summary>
        /// Location Page's store location descriptor
        /// </summary>
        [DeserializeAs(Name = "store_location_descriptor")]
        [JsonProperty(PropertyName = "store_location_descriptor", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string StoreLocationDescriptor { get; set; }

        /// <summary>
        /// Unique store number for this location Page
        /// </summary>
        [DeserializeAs(Name = "store_number")]
        [JsonProperty(PropertyName = "store_number", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? StoreNumber { get; set; }

        /// <summary>
        /// The studio for the film production. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "studio")]
        [JsonProperty(PropertyName = "studio", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Studio { get; set; }

        /// <summary>
        /// The number of people talking about this Page
        /// </summary>
        [DeserializeAs(Name = "talking_about_count")]
        [JsonProperty(PropertyName = "talking_about_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? TalkingAboutCount { get; set; }

        /// <summary>
        /// Unread message count for the Page. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "unread_message_count")]
        [JsonProperty(PropertyName = "unread_message_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? UnreadMessageCount { get; set; }

        /// <summary>
        /// Number of unread notifications. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "unread_notif_count")]
        [JsonProperty(PropertyName = "unread_notif_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? UnreadNotificationCount { get; set; }

        /// <summary>
        /// Unseen message count for the Page. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "unseen_message_count")]
        [JsonProperty(PropertyName = "unseen_message_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? UnseenMessageCount { get; set; }

        /// <summary>
        /// The alias of the Page.
        /// </summary>
        [DeserializeAs(Name = "username")]
        [JsonProperty(PropertyName = "username", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UserName { get; set; }

        /// <summary>
        /// Showing whether this Page is verified and in what color e.g. blue verified, gray verified or not verified
        /// </summary>
        [DeserializeAs(Name = "verification_status")]
        [JsonProperty(PropertyName = "verification_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string VerificationStatus { get; set; }

        /// <summary>
        /// Voip info
        /// </summary>
        [DeserializeAs(Name = "voip_info")]
        [JsonProperty(PropertyName = "voip_info", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public VoipInfo VOIPInfo { get; set; }

        /// <summary>
        /// The URL of the Page's website
        /// </summary>
        [DeserializeAs(Name = "website")]
        [JsonProperty(PropertyName = "website", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Website { get; set; }

        /// <summary>
        /// The number of visits to this Page's location.
        /// </summary>
        [DeserializeAs(Name = "were_here_count")]
        [JsonProperty(PropertyName = "were_here_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? WereHereCount { get; set; }

        /// <summary>
        /// The writer of the TV show. Applicable to TV Shows
        /// </summary>
        [DeserializeAs(Name = "written_by")]
        [JsonProperty(PropertyName = "written_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string WrittenBy { get; set; }
    }
}
