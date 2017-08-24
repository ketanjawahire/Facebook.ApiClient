using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// This represents a Facebook Page.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/</para>
    /// </summary>
    public class Page
    {
        /// <summary>
        /// Page ID. No access token is required to access this field
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// Information about the Page
        /// </summary>
        [DeserializeAs(Name = "about")]
        public string About { get; set; }

        /// <summary>
        /// The access token you can use to act as the Page. Only visible to Page Admins
        /// </summary>
        [DeserializeAs(Name = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// The Page's currently running promotion campaign
        /// </summary>
        [DeserializeAs(Name = "ad_campaign")]
        public Campaign Campaign { get; set; }

        /// <summary>
        /// Affiliation of this person. Applicable to Pages representing people
        /// </summary>
        [DeserializeAs(Name = "affiliation")]
        public string Affiliation { get; set; }

        /// <summary>
        /// App ID for app-owned Pages and app Pages
        /// </summary>
        [DeserializeAs(Name = "app_id")]
        public int AppId { get; set; }

        /// <summary>
        /// AppLinks data associated with the Page's URL
        /// </summary>
        [DeserializeAs(Name = "app_links")]
        public AppLinks Applinks { get; set; }

        /// <summary>
        /// Artists the band likes. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "artists_we_like")]
        public string ArtistsWeLike { get; set; }

        /// <summary>
        /// relevance score of an asset
        /// </summary>
        [DeserializeAs(Name = "asset_score")]
        public float? AssetScore { get; set; }

        /// <summary>
        /// Dress code of the business. Applicable to Restaurants or Nightlife. Can be one of Casual, Dressy or Unspecified
        /// </summary>
        [DeserializeAs(Name = "attire")]
        public string Attire { get; set; }

        /// <summary>
        /// The awards information of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "awards")]
        public string Awards { get; set; }

        /// <summary>
        /// Band interests. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "band_interests")]
        public string BandInterests { get; set; }

        /// <summary>
        /// Members of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "band_members")]
        public string BandMembers { get; set; }

        /// <summary>
        /// The best available Page on Facebook for the concept represented by this Page
        /// </summary>
        [DeserializeAs(Name = "best_page")]
        public Page BestPage { get; set; }

        /// <summary>
        /// Biography of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "bio")]
        public string Bio { get; set; }

        /// <summary>
        /// Birthday of this person. Applicable to Pages representing people
        /// </summary>
        [DeserializeAs(Name = "birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// Booking agent of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "booking_agent")]
        public string BookingAgent { get; set; }

        /// <summary>
        /// Year vehicle was built. Applicable to Vehicles
        /// </summary>
        [DeserializeAs(Name = "built")]
        public string Built { get; set; }

        /// <summary>
        /// The Business associated with this Page
        /// </summary>
        [DeserializeAs(Name = "business")]
        public string Business { get; set; }

        /// <summary>
        /// Whether this page has checkin functionality enabled
        /// </summary>
        [DeserializeAs(Name = "can_checkin")]
        public bool CanCheckin { get; set; }

        /// <summary>
        /// Whether the current session user can post on this Page
        /// </summary>
        [DeserializeAs(Name = "can_post")]
        public bool CanPost { get; set; }

        /// <summary>
        /// The Page's category. e.g. Product/Service, Computers/Technology
        /// </summary>
        [DeserializeAs(Name = "category")]
        public string Category { get; set; }

        /// <summary>
        /// The Page's sub-categories
        /// </summary>
        [DeserializeAs(Name = "category_list")]
        public IList<PageCategory> CategoryList { get; set; }

        /// <summary>
        /// Number of checkins at a place represented by a Page
        /// </summary>
        [DeserializeAs(Name = "checkins")]
        public int Checkins { get; set; }

        /// <summary>
        /// The company overview. Applicable to Companies
        /// </summary>
        [DeserializeAs(Name = "company_overview")]
        public string CompanyOverview { get; set; }

        /// <summary>
        /// The mailing or contact address for this page.
        /// </summary>
        [DeserializeAs(Name = "contact_address")]
        public MailingAddress ContactAddress { get; set; }

        /// <summary>
        /// Social context for this Page
        /// </summary>
        [DeserializeAs(Name = "context")]
        public OpenGraphContext Context { get; set; }

        /// <summary>
        /// If this is a Page in a Global Pages hierarchy, the number of people who are being directed to this Page.
        /// </summary>
        [DeserializeAs(Name = "country_page_likes")]
        public string CountryPageLikes { get; set; }

        /// <summary>
        /// Information about the page's cover photo
        /// </summary>
        [DeserializeAs(Name = "cover")]
        public CoverPhoto Cover { get; set; }

        /// <summary>
        /// Culinary team of the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "culinary_team")]
        public string CulinaryTeam { get; set; }

        /// <summary>
        /// Current location of the Page
        /// </summary>
        [DeserializeAs(Name = "current_location")]
        public string CurrentLocation { get; set; }

        /// <summary>
        /// The description of the Page
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The description of the Page in raw HTML
        /// </summary>
        [DeserializeAs(Name = "description_html")]
        public string DescriptionHTML { get; set; }

        /// <summary>
        /// The director of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "directed_by")]
        public string DirectedBy { get; set; }

        /// <summary>
        /// Subtext about the Page being viewed
        /// </summary>
        [DeserializeAs(Name = "display_subtext")]
        public string DisplaySubtext { get; set; }

        /// <summary>
        /// The emails listed in the About section of a Page
        /// </summary>
        [DeserializeAs(Name = "emails")]
        public IList<string> Emails { get; set; }

        /// <summary>
        /// The social sentence and like count information for this Page. This is the same info used for the like button
        /// </summary>
        [DeserializeAs(Name = "engagement")]
        public Engagement Engagement { get; set; }

        /// <summary>
        /// Video Featured by the Page.
        /// </summary>
        [DeserializeAs(Name = "featured_video")]
        public Video FeaturedVideo { get; set; }

        /// <summary>
        /// Features of the vehicle. Applicable to Vehicles
        /// </summary>
        [DeserializeAs(Name = "features")]
        public string Features { get; set; }

        /// <summary>
        /// The restaurant's food styles. Applicable to Restaurants
        /// </summary>
        [DeserializeAs(Name = "food_styles")]
        public IList<string> FoodStyles { get; set; }

        /// <summary>
        /// When the company was founded. Applicable to Pages in the Company category
        /// </summary>
        [DeserializeAs(Name = "founded")]
        public string Founded { get; set; }

        /// <summary>
        /// General information provided by the Page
        /// </summary>
        [DeserializeAs(Name = "general_info")]
        public string GeneralInfo { get; set; }

        /// <summary>
        /// General manager of the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "general_manager")]
        public string GeneralManager { get; set; }

        /// <summary>
        /// The genre of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "genre")]
        public string Genre { get; set; }

        /// <summary>
        /// The name of the Page with country codes appended for Global Brand Pages. Only visible to the Page admin
        /// </summary>
        [DeserializeAs(Name = "global_brand_page_name")]
        public string GlobalBrandPageName { get; set; }

        /// <summary>
        /// This brand's global Root ID
        /// </summary>
        [DeserializeAs(Name = "global_brand_root_id")]
        public long? GlobalBrandRootId { get; set; }

        /// <summary>
        /// Indicates whether this Page has added the app making the query in a Page tab
        /// </summary>
        [DeserializeAs(Name = "has_added_app")]
        public bool HasAddedApp { get; set; }

        /// <summary>
        /// Hometown of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "hometown")]
        public string Hometown { get; set; }

        /// <summary>
        /// Indicates a single range of opening hours for a day. 
        /// </summary>
        [DeserializeAs(Name = "hours")]
        public IDictionary<string, string> Hours { get; set; }

        /// <summary>
        /// Legal information about the Page publishers
        /// </summary>
        [DeserializeAs(Name = "impressum")]
        public string Impressum { get; set; }

        /// <summary>
        /// Influences on the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "influences")]
        public string Influences { get; set; }

        /// <summary>
        /// Indicates whether this location is always open
        /// </summary>
        [DeserializeAs(Name = "is_always_open")]
        public bool? IsAlwaysOpen { get; set; }

        /// <summary>
        /// Indicates whether the Page is a community Page
        /// </summary>
        [DeserializeAs(Name = "is_community_page")]
        public bool? IsCommunityPage { get; set; }

        /// <summary>
        /// Whether the business corresponding to this Page is permanently closed
        /// </summary>
        [DeserializeAs(Name = "is_permanently_closed")]
        public bool? IsPermanentlyClosed { get; set; }

        /// <summary>
        /// Indicates whether the Page is published and visible to non-admins
        /// </summary>
        [DeserializeAs(Name = "is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Indicates whether the Page is unclaimed
        /// </summary>
        [DeserializeAs(Name = "is_unclaimed")]
        public bool? IsUnclaimed { get; set; }

        /// <summary>
        /// Pages with a large number of followers can be manually verified by Facebook as having an authentic identity
        /// </summary>
        [DeserializeAs(Name = "is_verified")]
        public string IsVerified { get; set; }

        /// <summary>
        /// last used time of this object by the current viewer
        /// </summary>
        [DeserializeAs(Name = "last_used_time")]
        public DateTime? LastUsedTime { get; set; }

        /// <summary>
        /// Indicates whether a user has accepted the TOS for running LeadGen Ads on the Page
        /// </summary>
        [DeserializeAs(Name = "leadgen_tos_accepted")]
        public bool? LeadgenTOSAccepted { get; set; }

        /// <summary>
        /// The number of users who like the Page.
        /// </summary>
        [DeserializeAs(Name = "likes")]
        public int? Likes { get; set; }

        /// <summary>
        /// The Page's Facebook URL
        /// </summary>
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The location of this place. Applicable to all Places
        /// </summary>
        [DeserializeAs(Name = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Members of this org. Applicable to Pages representing Team Orgs
        /// </summary>
        [DeserializeAs(Name = "members")]
        public string Members { get; set; }

        /// <summary>
        /// The company mission. Applicable to Companies
        /// </summary>
        [DeserializeAs(Name = "mission")]
        public string Mission { get; set; }

        /// <summary>
        /// MPG of the vehicle. Applicable to Vehicles
        /// </summary>
        [DeserializeAs(Name = "mpg")]
        public string MPG { get; set; }

        /// <summary>
        /// The name of the Page
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The name of the Page with its location and/or global brand descriptor
        /// </summary>
        [DeserializeAs(Name = "name_with_location_descriptor")]
        public string NameWithLocalDescriptor { get; set; }

        /// <summary>
        /// The TV network for the TV show. Applicable to TV Shows
        /// </summary>
        [DeserializeAs(Name = "network")]
        public string Network { get; set; }

        /// <summary>
        /// The number of people who have liked the Page, since the last login. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "new_like_count")]
        public int? NewLikeCount { get; set; }

        /// <summary>
        /// Offer eligibility status. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "offer_eligible")]
        public bool? OfferEligible { get; set; }

        /// <summary>
        /// owner business of this object
        /// </summary>
        [DeserializeAs(Name = "owner_business")]
        public Business OwnerBusiness { get; set; }

        /// <summary>
        /// Parent Page for this Page
        /// </summary>
        [DeserializeAs(Name = "parent_page")]
        public Page ParentPage { get; set; }

        /// <summary>
        /// Parking information. Applicable to Businesses and Places
        /// </summary>
        [DeserializeAs(Name = "parking")]
        public PageParking Parking { get; set; }

        /// <summary>
        /// Payment options accepted by the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "payment_options")]
        public PagePaymentOptions PaymentOptions { get; set; }

        /// <summary>
        /// Personal information. Applicable to Pages representing People
        /// </summary>
        [DeserializeAs(Name = "personal_info")]
        public string PersonalInformation { get; set; }

        /// <summary>
        /// Personal interests. Applicable to Pages representing People
        /// </summary>
        [DeserializeAs(Name = "personal_interests")]
        public string PersonalInterests { get; set; }

        /// <summary>
        /// Pharmacy safety information. Applicable to Pharmaceutical companies
        /// </summary>
        [DeserializeAs(Name = "pharma_safety_info")]
        public string PharmaSafetyInformation { get; set; }

        /// <summary>
        /// Phone number provided by a Page
        /// </summary>
        [DeserializeAs(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// For places, the category of the place
        /// </summary>
        [DeserializeAs(Name = "place_type")]
        public string PlaceType { get; set; }

        /// <summary>
        /// The plot outline of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "plot_outline")]
        public string PlotOutline { get; set; }

        /// <summary>
        /// Press contact information of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "press_contact")]
        public string PressContact { get; set; }

        /// <summary>
        /// Price range of the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "price_range")]
        public string PriceRange { get; set; }

        /// <summary>
        /// The productor of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "produced_by")]
        public string ProducedBy { get; set; }

        /// <summary>
        /// The products of this company. Applicable to Companies
        /// </summary>
        [DeserializeAs(Name = "products")]
        public string Products { get; set; }

        /// <summary>
        /// Reason why a post isn't eligible for boosting. Only visible to Page Admins
        /// </summary>
        [DeserializeAs(Name = "promotion_eligible")]
        public bool? IsPromotionEligible { get; set; }

        /// <summary>
        /// Reason, for which boosted posts are not eligible. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "promotion_ineligible_reason")]
        public string PromotionInEligibleReason { get; set; }

        /// <summary>
        /// Public transit to the business. Applicable to Restaurants or Nightlife
        /// </summary>
        [DeserializeAs(Name = "public_transit")]
        public string PublicTransit { get; set; }

        /// <summary>
        /// Record label of the band. Applicable to Bands
        /// </summary>
        [DeserializeAs(Name = "record_label")]
        public string RecordLabel { get; set; }

        /// <summary>
        /// The film's release date. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Services the restaurant provides. Applicable to Restaurants
        /// </summary>
        [DeserializeAs(Name = "restaurant_services")]
        public PageRestaurantServices RestaurantServices { get; set; }

        /// <summary>
        /// The restaurant's specialties. Applicable to Restaurants
        /// </summary>
        [DeserializeAs(Name = "restaurant_specialties")]
        public PageRestaurantSpecialties RestaurantSpecialties { get; set; }

        /// <summary>
        /// The air schedule of the TV show. Applicable to TV Shows
        /// </summary>
        [DeserializeAs(Name = "schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// The screenwriter of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "screenplay_by")]
        public string ScreenplayBy { get; set; }

        /// <summary>
        /// The season information of the TV Show. Applicable to TV Shows
        /// </summary>
        [DeserializeAs(Name = "season")]
        public string Season { get; set; }

        /// <summary>
        /// The page address, if any, in a simple single line format.
        /// </summary>
        [DeserializeAs(Name = "single_line_address")]
        public string SingleLineAddress { get; set; }

        /// <summary>
        /// The cast of the film. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "starring")]
        public string Starring { get; set; }

        /// <summary>
        /// Information about when the entity represented by the Page was started
        /// </summary>
        [DeserializeAs(Name = "start_info")]
        public PageStartInfo StartInfo { get; set; }

        /// <summary>
        /// Location Page's store location descriptor
        /// </summary>
        [DeserializeAs(Name = "store_location_descriptor")]
        public string StoreLocationDescriptor { get; set; }

        /// <summary>
        /// Unique store number for this location Page
        /// </summary>
        [DeserializeAs(Name = "store_number")]
        public int? StoreNumber { get; set; }

        /// <summary>
        /// The studio for the film production. Applicable to Films
        /// </summary>
        [DeserializeAs(Name = "studio")]
        public string Studio { get; set; }

        /// <summary>
        /// The number of people talking about this Page
        /// </summary>
        [DeserializeAs(Name = "talking_about_count")]
        public int? TalkingAboutCount { get; set; }

        /// <summary>
        /// Unread message count for the Page. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "unread_message_count")]
        public int? UnreadMessageCount { get; set; }

        /// <summary>
        /// Number of unread notifications. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "unread_notif_count")]
        public int? UnreadNotificationCount { get; set; }

        /// <summary>
        /// Unseen message count for the Page. Only visible to a page admin
        /// </summary>
        [DeserializeAs(Name = "unseen_message_count")]
        public int? UnseenMessageCount { get; set; }

        /// <summary>
        /// The alias of the Page.
        /// </summary>
        [DeserializeAs(Name = "username")]
        public string UserName { get; set; }

        /// <summary>
        /// Showing whether this Page is verified and in what color e.g. blue verified, gray verified or not verified
        /// </summary>
        [DeserializeAs(Name = "verification_status")]
        public string VerificationStatus { get; set; }

        /// <summary>
        /// Voip info
        /// </summary>
        [DeserializeAs(Name = "voip_info")]
        public VoipInfo VOIPInfo { get; set; }

        /// <summary>
        /// The URL of the Page's website
        /// </summary>
        [DeserializeAs(Name = "website")]
        public string Website { get; set; }

        /// <summary>
        /// The number of visits to this Page's location.
        /// </summary>
        [DeserializeAs(Name = "were_here_count")]
        public int? WereHereCount { get; set; }

        /// <summary>
        /// The writer of the TV show. Applicable to TV Shows
        /// </summary>
        [DeserializeAs(Name = "written_by")]
        public string WrittenBy { get; set; }
    }
}
