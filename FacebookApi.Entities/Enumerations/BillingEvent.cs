namespace FacebookApi.Entities.Enumerations
{
    /// <summary>
    /// The billing event that this adset is using
    /// </summary>
    public enum BillingEvent
    {
        /// <summary>
        /// Pay when people install your app.
        /// </summary>
        APP_INSTALLS,

        /// <summary>
        /// Pay when people click anywhere in the ad. 
        /// </summary>
        CLICKS,

        /// <summary>
        /// Pay when the ads are shown to people.
        /// </summary>
        IMPRESSIONS,

        /// <summary>
        /// Pay when people click on the link of the ad.
        /// </summary>
        LINK_CLICKS,

        /// <summary>
        ///  Pay when people claim the offer.
        /// </summary>
        OFFER_CLAIMS,

        /// <summary>
        /// Pay when people like your page.
        /// </summary>
        PAGE_LIKES,

        /// <summary>
        /// Pay when people engage with your post.
        /// </summary>
        POST_ENGAGEMENT,

        /// <summary>
        /// Pay when people watch videos.
        /// </summary>
        VIDEO_VIEWS,

        /// <summary>
        /// VIDEO_VIEWS_15S
        /// </summary>
        VIDEO_VIEWS_15S,


    }
}
