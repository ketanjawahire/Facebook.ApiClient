using RestSharp.Deserializers;
using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;

namespace FacebookApi.Entities
{
    /// <summary>
    /// This insights edge provides a single, consistent interface to retrieve an ad's statistics.
    /// <para>https://developers.facebook.com/docs/marketing-api/insights/</para>
    /// </summary>
    public class Insight : BaseEntity
    {
        /// <summary>
        /// The ID number of your ad account, which groups your advertising activity. Your ad account includes your campaigns, ads and billing.
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        [JsonProperty(PropertyName = "account_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AccountId { get; set; }

        /// <summary>
        /// The name of your ad account, which groups your advertising activity. Your ad account includes your campaigns, ads and billing.
        /// </summary>
        [DeserializeAs(Name = "account_name")]
        [JsonProperty(PropertyName = "account_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AccountName { get; set; }

        /// <summary>
        /// The total value of all conversions attributed to your ads.
        /// </summary>
        [DeserializeAs(Name = "action_values")]
        [JsonProperty(PropertyName = "action_values", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> ActionValues { get; set; }

        /// <summary>
        /// The total number of actions people took that are attributed to your ads. Actions may include engagement, clicks or conversions.
        /// </summary>
        [DeserializeAs(Name = "actions")]
        [JsonProperty(PropertyName = "actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> Actions { get; set; }

        /// <summary>
        /// The unique ID of the ad you're viewing in reporting.
        /// </summary>
        [DeserializeAs(Name = "ad_id")]
        [JsonProperty(PropertyName = "ad_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdId { get; set; }

        /// <summary>
        /// The name of the ad you're viewing in reporting.
        /// </summary>
        [DeserializeAs(Name = "ad_name")]
        [JsonProperty(PropertyName = "ad_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdName { get; set; }

        /// <summary>
        /// The unique ID of the ad set you're viewing in reporting. An ad set is a group of ads that share the same budget, schedule, delivery optimization and targeting.
        /// </summary>
        [DeserializeAs(Name = "adset_id")]
        [JsonProperty(PropertyName = "adset_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdsetId { get; set; }

        /// <summary>
        /// The name of the ad set you're viewing in reporting. An ad set is a group of ads that share the same budget, schedule, delivery optimization and targeting.
        /// </summary>
        [DeserializeAs(Name = "adset_name")]
        [JsonProperty(PropertyName = "adset_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdsetName { get; set; }

        /// <summary>
        /// The method by which you pay for and target ads in your campaigns: through dynamic auction bidding, fixed-price bidding, or reach and frequency buying.
        /// </summary>
        [DeserializeAs(Name = "buying_type")]
        [JsonProperty(PropertyName = "buying_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BuyingType { get; set; }

        /// <summary>
        /// The number of times people clicked the call-to-action button on your ad.
        /// </summary>
        [DeserializeAs(Name = "call_to_action_clicks")]
        [JsonProperty(PropertyName = "call_to_action_clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CallToActionClicks { get; set; }

        /// <summary>
        /// The unique ID number of the ad campaign you're viewing in reporting. Your campaign contains ad sets and ads.
        /// </summary>
        [DeserializeAs(Name = "campaign_id")]
        [JsonProperty(PropertyName = "campaign_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The name of the ad campaign you're viewing in reporting. Your campaign contains ad sets and ads.
        /// </summary>
        [DeserializeAs(Name = "campaign_name")]
        [JsonProperty(PropertyName = "campaign_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CampaignName { get; set; }

        /// <summary>
        /// The average percentage of the Facebook Canvas that people saw. Canvas is a screen that opens on mobile after a person clicks the Canvas link in your ad. It may include a series of interactive or multimedia components, including video, images, product catalogs and more.
        /// </summary>
        [DeserializeAs(Name = "canvas_avg_view_percent")]
        [JsonProperty(PropertyName = "canvas_avg_view_percent", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CanvasAvgViewPercent { get; set; }

        /// <summary>
        /// The average total time, in seconds, that people spent viewing a Facebook Canvas. Canvas is a screen that opens on mobile after a person clicks the Canvas link in your ad. It may include a series of interactive or multimedia components, including video, images, product catalogs and more.
        /// </summary>
        [DeserializeAs(Name = "canvas_avg_view_time")]
        [JsonProperty(PropertyName = "canvas_avg_view_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CanvasAvgVIewTime { get; set; }

        /// <summary>
        /// The average percentage of time spent viewing each component of a Facebook Canvas. Canvas is a screen that opens on mobile after a person clicks the Canvas link in your ad. It may include a series of interactive or multimedia components, including video, images, product catalogs and more.
        /// </summary>
        [DeserializeAs(Name = "canvas_component_avg_pct_view")]
        [JsonProperty(PropertyName = "canvas_component_avg_pct_view", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> CanvasComponentAvgPctView { get; set; }

        /// <summary>
        /// The number of clicks on your ads.
        /// </summary>
        [DeserializeAs(Name = "clicks")]
        [JsonProperty(PropertyName = "clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Clicks { get; set; }

        /// <summary>
        /// The average cost for each 10-second video view.
        /// </summary>
        [DeserializeAs(Name = "cost_per_10_sec_video_view")]
        [JsonProperty(PropertyName = "cost_per_10_sec_video_view", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> CostPer10SecVideoView { get; set; }

        /// <summary>
        /// The average cost of a relevant action.
        /// </summary>
        [DeserializeAs(Name = "cost_per_action_type")]
        [JsonProperty(PropertyName = "cost_per_action_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> CostPerActionType { get; set; }

        /// <summary>
        /// The average cost for each estimated ad recall lift. This metric is only available for assets in the Brand Awareness Objective.
        /// </summary>
        [DeserializeAs(Name = "cost_per_estimated_ad_recallers")]
        [JsonProperty(PropertyName = "cost_per_estimated_ad_recallers", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> CostPerEstimatedAdRecallers { get; set; }

        /// <summary>
        /// The average cost of each inline link click.
        /// </summary>
        [DeserializeAs(Name = "cost_per_inline_link_click")]
        [JsonProperty(PropertyName = "cost_per_inline_link_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CostPerInlineLinkClick { get; set; }

        /// <summary>
        /// The average cost of each inline post engagement.
        /// </summary>
        [DeserializeAs(Name = "cost_per_inline_post_engagement")]
        [JsonProperty(PropertyName = "cost_per_inline_post_engagement", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CostPerInlinePostEngagement { get; set; }

        /// <summary>
        /// The average cost for each outbound click.
        /// </summary>
        [DeserializeAs(Name = "cost_per_outbound_click")]
        [JsonProperty(PropertyName = "cost_per_outbound_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CostPerOutboundClick { get; set; }

        /// <summary>
        /// The average cost of a relevant action.
        /// </summary>
        [DeserializeAs(Name = "cost_per_total_action")]
        [JsonProperty(PropertyName = "cost_per_total_action", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public double? CostPerTotalAction { get; set; }

        /// <summary>
        /// The average cost of each unique action.
        /// </summary>
        [DeserializeAs(Name = "cost_per_unique_action_type")]
        [JsonProperty(PropertyName = "cost_per_unique_action_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> CostPerUniqueActionType { get; set; }

        /// <summary>
        /// The average cost for each unique click (all).
        /// </summary>
        [DeserializeAs(Name = "cost_per_unique_click")]
        [JsonProperty(PropertyName = "cost_per_unique_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CostPerUniqueClick { get; set; }

        /// <summary>
        /// The average cost of each unique inline link click.
        /// </summary>
        [DeserializeAs(Name = "cost_per_unique_inline_link_click")]
        [JsonProperty(PropertyName = "cost_per_unique_inline_link_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CostPerUniqueInlineLinkClick { get; set; }

        /// <summary>
        /// The average cost for each unique outbound click.
        /// </summary>
        [DeserializeAs(Name = "cost_per_unique_outbound_click")]
        [JsonProperty(PropertyName = "cost_per_unique_outbound_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CostPerUniqueOutboundClick { get; set; }


        /// <summary>
        /// The average cost for each click (all).
        /// </summary>
        [DeserializeAs(Name = "cpc")]
        [JsonProperty(PropertyName = "cpc", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CPC { get; set; }

        /// <summary>
        /// The average cost for 1,000 impressions.
        /// </summary>
        [DeserializeAs(Name = "cpm")]
        [JsonProperty(PropertyName = "cpm", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CPM { get; set; }

        /// <summary>
        /// The average cost to reach 1,000 people.
        /// </summary>
        [DeserializeAs(Name = "cpp")]
        [JsonProperty(PropertyName = "cpp", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CPP { get; set; }

        /// <summary>
        /// The percentage of times people saw your ad and performed a click (all).
        /// </summary>
        [DeserializeAs(Name = "ctr")]
        [JsonProperty(PropertyName = "ctr", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CTR { get; set; }


        /// <summary>
        /// The start date for your data. This is controlled by the date range you've selected for your reporting view.
        /// </summary>
        [DeserializeAs(Name = "date_start")]
        [JsonProperty(PropertyName = "date_start", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DateStart { get; set; }

        /// <summary>
        /// The end date for your data. This is controlled by the date range you've selected for your reporting view.
        /// </summary>
        [DeserializeAs(Name = "date_stop")]
        [JsonProperty(PropertyName = "date_stop", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DateStop { get; set; }

        /// <summary>
        /// The rate at which an estimated number of additional people, when asked, would remember seeing your ads within 2 days. This metric is only available for assets in the Brand Awareness Objective.
        /// </summary>
        [DeserializeAs(Name = "estimated_ad_recall_rate")]
        [JsonProperty(PropertyName = "estimated_ad_recall_rate", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public decimal? EstimatedAdRecallRate { get; set; }

        /// <summary>
        /// An estimate of the number of additional people who may remember seeing your ads, if asked, within 2 days. This metric is only available for assets in the Brand Awareness Objective.
        /// </summary>
        [DeserializeAs(Name = "estimated_ad_recallers")]
        [JsonProperty(PropertyName = "estimated_ad_recallers", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EstimatedAdRecallers { get; set; }

        /// <summary>
        /// The average number of times each person saw your ad.
        /// </summary>
        [DeserializeAs(Name = "frequency")]
        [JsonProperty(PropertyName = "frequency", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Frequency { get; set; }

        /// <summary>
        /// The number of times your ads were viewed.
        /// </summary>
        [DeserializeAs(Name = "impressions")]
        [JsonProperty(PropertyName = "impressions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Impressions { get; set; }

        /// <summary>
        /// The percentage of time people saw your ads and performed an inline link click.
        /// </summary>
        [DeserializeAs(Name = "inline_link_click_ctr")]
        [JsonProperty(PropertyName = "inline_link_click_ctr", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string InlineLinkClickCtr { get; set; }

        /// <summary>
        /// The number of clicks on links to select destinations or experiences, on or off Facebook-owned properties. Inline link clicks use a fixed 1-day-click attribution window.
        /// </summary>
        [DeserializeAs(Name = "inline_link_clicks")]
        [JsonProperty(PropertyName = "inline_link_clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string InlineLinkClicks { get; set; }

        /// <summary>
        /// The total number of actions that people take involving your ads. Inline post engagements use a fixed 1-day-click attribution window.
        /// </summary>
        [DeserializeAs(Name = "inline_post_engagement")]
        [JsonProperty(PropertyName = "inline_post_engagement", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string InlinePostEngagement { get; set; }

        /// <summary>
        /// The total return on ad spend (ROAS) from mobile app purchases. This is based on the value that you assigned when you set up the app event.
        /// </summary>
        [DeserializeAs(Name = "mobile_app_purchase_roas")]
        [JsonProperty(PropertyName = "mobile_app_purchase_roas", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MobileAppPurchaseRoas { get; set; }

        /// <summary>
        /// The objective you selected for your campaign. Your objective reflects the goal you want to achieve with your advertising.
        /// </summary>
        [DeserializeAs(Name = "objective")]
        [JsonProperty(PropertyName = "objective", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Objective { get; set; }

        /// <summary>
        /// The number of clicks on links that take people off Facebook-owned properties.
        /// </summary>
        [DeserializeAs(Name = "outbound_clicks")]
        [JsonProperty(PropertyName = "outbound_clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> OutboundClicks { get; set; }

        /// <summary>
        /// The percentage of times people saw your ad and performed an outbound click.
        /// </summary>
        [DeserializeAs(Name = "outbound_clicks_ctr")]
        [JsonProperty(PropertyName = "outbound_clicks_ctr", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> OutboundClicksCtr { get; set; }

        /// <summary>
        /// The number of people who saw your ads at least once. Reach is different from impressions, which may include multiple views of your ads by the same people.
        /// </summary>
        [DeserializeAs(Name = "reach")]
        [JsonProperty(PropertyName = "reach", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Reach { get; set; }

        /// <summary>
        /// A rating from 1 to 10 that estimates how well your target audience is responding to your ad. This score is shown after your ad receives more than 500 impressions. It's only visible when looking at reporting for ads and does not appear for ad sets and campaigns.
        /// </summary>
        [DeserializeAs(Name = "relevance_score")]
        [JsonProperty(PropertyName = "relevance_score", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string RelevanceScore { get; set; }

        /// <summary>
        /// The number of clicks (all) when your ad was displayed with social information, which shows other Facebook friends who engaged with your Facebook Page or ad.
        /// </summary>
        [DeserializeAs(Name = "social_clicks")]
        [JsonProperty(PropertyName = "social_clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SocialClicks { get; set; }

        /// <summary>
        /// The number of times your ads were viewed when displayed with social information, which shows Facebook friends who engaged with your Facebook Page or ad.
        /// </summary>
        [DeserializeAs(Name = "social_impressions")]
        [JsonProperty(PropertyName = "social_impressions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SocialImpressions { get; set; }

        /// <summary>
        /// The number of people who saw your ad when displayed with social information, which shows other Facebook friends who engaged with your Facebook Page or ad.
        /// </summary>
        [DeserializeAs(Name = "social_reach")]
        [JsonProperty(PropertyName = "social_reach", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SocialReach { get; set; }

        /// <summary>
        /// The total amount you've spent so far for your ads showed with social information. (ex: Jane Doe likes this).
        /// </summary>
        [DeserializeAs(Name = "social_spend")]
        [JsonProperty(PropertyName = "social_spend", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SocialSpend { get; set; }

        /// <summary>
        /// The estimated total amount of money you've spent on your campaign, ad set or ad during its schedule.
        /// </summary>
        [DeserializeAs(Name = "spend")]
        [JsonProperty(PropertyName = "spend", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Spend { get; set; }

        /// <summary>
        /// The total value of all conversions attributed to your ads.
        /// </summary>
        [DeserializeAs(Name = "total_action_value")]
        [JsonProperty(PropertyName = "total_action_value", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TotalActionValue { get; set; }

        /// <summary>
        /// The total number of actions people took that are attributed to your ads. Actions may include engagement, clicks or conversions.
        /// </summary>
        [DeserializeAs(Name = "total_actions")]
        [JsonProperty(PropertyName = "total_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TotalActions { get; set; }

        /// <summary>
        /// The number of people who took an action that was attributed to your ads.
        /// </summary>
        [DeserializeAs(Name = "total_unique_actions")]
        [JsonProperty(PropertyName = "total_unique_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TotalUniqueActions { get; set; }

        /// <summary>
        /// The number of people who took an action that was attributed to your ads.
        /// </summary>
        [DeserializeAs(Name = "unique_actions")]
        [JsonProperty(PropertyName = "unique_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> UniqueActions { get; set; }

        /// <summary>
        /// The number of people who performed a click (all).
        /// </summary>
        [DeserializeAs(Name = "unique_clicks")]
        [JsonProperty(PropertyName = "unique_clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UniqueClicks { get; set; }

        /// <summary>
        /// The percentage of people who saw your ad and performed a unique click (all).
        /// </summary>
        [DeserializeAs(Name = "unique_ctr")]
        [JsonProperty(PropertyName = "unique_ctr", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UniqueCtr { get; set; }

        /// <summary>
        /// The percentage of times people saw your ad and performed a link click. Inline click-through rate uses a fixed 1-day-click attribution window.
        /// </summary>
        [DeserializeAs(Name = "unique_inline_link_click_ctr")]
        [JsonProperty(PropertyName = "unique_inline_link_click_ctr", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UniqueInlineLinkClickCtr { get; set; }

        /// <summary>
        /// The number of people who performed an inline link click
        /// </summary>
        [DeserializeAs(Name = "unique_inline_link_clicks")]
        [JsonProperty(PropertyName = "unique_inline_link_clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UniqueInlineLinkClicks { get; set; }

        /// <summary>
        /// The percentage of people who saw your ad and performed a link click.
        /// </summary>
        [DeserializeAs(Name = "unique_link_clicks_ctr")]
        [JsonProperty(PropertyName = "unique_link_clicks_ctr", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UniqueLinkClicksCtr { get; set; }

        /// <summary>
        /// The number of people who performed an outbound click.
        /// </summary>
        [DeserializeAs(Name = "unique_outbound_clicks")]
        [JsonProperty(PropertyName = "unique_outbound_clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> UniqueOutboundClicks { get; set; }

        /// <summary>
        /// The number of people who performed a click (all) on your ad when it was displayed with social information, which shows other Facebook friends who engaged with your Facebook Page or ad.
        /// </summary>
        [DeserializeAs(Name = "unique_social_clicks")]
        [JsonProperty(PropertyName = "unique_social_clicks", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UniqueSocialClicks { get; set; }

        /// <summary>
        /// The number of times your video was watched for an aggregate of at least 10 seconds, or for nearly its total length, whichever happened first.
        /// </summary>
        [DeserializeAs(Name = "video_10_sec_watched_actions")]
        [JsonProperty(PropertyName = "video_10_sec_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> Video10SecWatchedActions { get; set; }

        /// <summary>
        /// The number of times your video was watched for an aggregate of at least 15 seconds, or for nearly its total length, whichever happened first.
        /// </summary>
        [DeserializeAs(Name = "video_15_sec_watched_actions")]
        [JsonProperty(PropertyName = "video_15_sec_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> Video15SecWatchedActions { get; set; }

        /// <summary>
        /// The number of times your video was watched for an aggregate of at least 30 seconds, or for nearly its total length, whichever happened first.
        /// </summary>
        [DeserializeAs(Name = "video_30_sec_watched_actions")]
        [JsonProperty(PropertyName = "video_30_sec_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> Video30SecWatchedActions { get; set; }

        /// <summary>
        /// The average percentage of your video that people watched.
        /// </summary>
        [DeserializeAs(Name = "video_avg_percent_watched_actions")]
        [JsonProperty(PropertyName = "video_avg_percent_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> VideoAvgPercentWatchedActions { get; set; }

        /// <summary>
        /// The average time a video was watched.
        /// </summary>
        [DeserializeAs(Name = "video_avg_time_watched_actions")]
        [JsonProperty(PropertyName = "video_avg_time_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> VideoAvgTimeWatchedActions { get; set; }

        /// <summary>
        /// The number of times your video was watched at 100% of its length, including watches that skipped to this point.
        /// </summary>
        [DeserializeAs(Name = "video_p100_watched_actions")]
        [JsonProperty(PropertyName = "video_p100_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> VideoP100WatchedActions { get; set; }

        /// <summary>
        /// The number of times your video was watched at 25% of its length, including watches that skipped to this point.
        /// </summary>
        [DeserializeAs(Name = "video_p25_watched_actions")]
        [JsonProperty(PropertyName = "video_p25_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> VideoP25WatchedActions { get; set; }

        /// <summary>
        /// The number of times your video was watched at 50% of its length, including watches that skipped to this point.
        /// </summary>
        [DeserializeAs(Name = "video_p50_watched_actions")]
        [JsonProperty(PropertyName = "video_p50_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> VideoP50WatchedActions { get; set; }

        /// <summary>
        /// The number of times your video was watched at 75% of its length, including watches that skipped to this point.
        /// </summary>
        [DeserializeAs(Name = "video_p75_watched_actions")]
        [JsonProperty(PropertyName = "video_p75_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> VideoP75WatchedActions { get; set; }

        /// <summary>
        /// The number of times your video was watched at 95% of its length, including watches that skipped to this point.
        /// </summary>
        [DeserializeAs(Name = "video_p95_watched_actions")]
        [JsonProperty(PropertyName = "video_p95_watched_actions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> VideoP95WatchedActions { get; set; }

        /// <summary>
        /// The percentage of times people saw your ad and performed a link click.
        /// </summary>
        [DeserializeAs(Name = "website_ctr")]
        [JsonProperty(PropertyName = "website_ctr", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> WebsiteCtr { get; set; }

        /// <summary>
        /// The total return on ad spend (ROAS) from website purchases. This is based on the value of all conversions recorded by the Facebook pixel on your website and attributed to your ads.
        /// </summary>
        [DeserializeAs(Name = "website_purchase_roas")]
        [JsonProperty(PropertyName = "website_purchase_roas", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdActionStats> WebsitePurchaseRoas { get; set; }

        /// <summary>
        /// Age Breakdown
        /// </summary>
        [DeserializeAs(Name = "age")]
        [JsonProperty(PropertyName = "age", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Age { get; set; }

        /// <summary>
        /// Gender breakdown
        /// </summary>
        [DeserializeAs(Name = "gender")]
        [JsonProperty(PropertyName = "gender", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Gender { get; set; }
    }
}
