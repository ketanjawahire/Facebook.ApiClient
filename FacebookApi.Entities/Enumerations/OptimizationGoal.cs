namespace FacebookApi.Entities.Enumerations
{

    /// <summary>
    /// Which optimization goal this ad set is using
    /// </summary>
    public enum OptimizationGoal
    {
        /// <summary>
        /// Only available in read mode for campaigns created pre v2.4
        /// </summary>
        NONE,

        /// <summary>
        /// Optimize for people more likely to install your app.
        /// </summary>
        APP_INSTALLS,

        /// <summary>
        /// Optimize to reach the most number of users who are likely to spend at least a minimum amount of time on the image or video
        /// </summary>
        BRAND_AWARENESS,

        /// <summary>
        ///  Optimize for people more likely to click anywhere in the ad.
        /// </summary>
        CLICKS,

        /// <summary>
        /// Optimize for people more likely to take a particular action in your app 
        /// </summary>
        ENGAGED_USERS,

        /// <summary>
        /// FBX only 
        /// </summary>
        EXTERNAL,

        /// <summary>
        /// Optimize for people more likely to attend your event 
        /// </summary>
        EVENT_RESPONSES,

        /// <summary>
        ///  Show the ads as many times as possible 
        /// </summary>
        IMPRESSIONS,

        /// <summary>
        /// Optimize for people more likely to fill out a lead generation form.
        /// </summary>
        LEAD_GENERATION,

        /// <summary>
        /// Optimize for people more likely to click in the link of the ad. 
        /// </summary>
        LINK_CLICKS,

        /// <summary>
        /// Optimize for people more likely to claim the offer.
        /// </summary>
        OFFER_CLAIMS,

        /// <summary>
        /// Optimize for people more likely to make a conversion in the site 
        /// </summary>
        OFFSITE_CONVERSIONS,

        /// <summary>
        /// Optimize for people more likely to engage with your page
        /// </summary>
        PAGE_ENGAGEMENT,

        /// <summary>
        /// Optimize for people more likely to like your page. 
        /// </summary>
        PAGE_LIKES,

        /// <summary>
        /// Optimize for people more likely to engage with your post.
        /// </summary>
        POST_ENGAGEMENT,

        /// <summary>
        /// Optimize to reach the most unique users of each day or interval specified in <see cref="AdSet.FrequencyControlSpec"/>
        /// </summary>
        REACH,

        /// <summary>
        /// Increase the number of impressions with social context.
        /// <para>I.e. with the names of one or more of the user's friends attached to the ad who have already liked the page or installed the app.</para>
        /// </summary>
        SOCIAL_IMPRESSIONS,

        /// <summary>
        /// Optimize for people more likely to watch videos
        /// </summary>
        VIDEO_VIEWS,

        /// <summary>
        /// APP_DOWNLOADS
        /// </summary>
        APP_DOWNLOADS,

        /// <summary>
        /// LANDING_PAGE_VIEWS
        /// </summary>
        LANDING_PAGE_VIEWS,


    }
}
