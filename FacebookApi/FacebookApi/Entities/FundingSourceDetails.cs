using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Funding Source Details
    /// <see cref="https://developers.facebook.com/docs/marketing-api/reference/ad-account/"/>
    /// </summary>
    public class FundingSourceDetails
    {
        /// <summary>
        /// ID of the payment method
        /// </summary>
        [DeserializeAs(Name = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// Details of the Facebook Ads Coupon from the payment method
        /// </summary>
        [DeserializeAs(Name = "COUPON")]
        public string Coupon { get; set; }

        /// <summary>
        /// Amount of Facebook Ads Coupon
        /// </summary>
        [DeserializeAs(Name = "AMOUNT")]
        public string Amount { get; set; }

        /// <summary>
        /// Currency of the Facebook Ads Coupon
        /// </summary>
        [DeserializeAs(Name = "CURRENCY")]
        public string Currency { get; set; }

        /// <summary>
        /// How the amount of Facebook Ads Coupon is displayed
        /// </summary>
        [DeserializeAs(Name = "DISPLAY_AMOUNT")]
        public string DisplayAmount { get; set; }

        /// <summary>
        /// When the coupon will expire
        /// </summary>
        [DeserializeAs(Name = "EXPIRATION")]
        public string Expiration { get; set; }

        /// <summary>
        ///  How the payment method is shown
        /// </summary>
        [DeserializeAs(Name = "DISPLAY_STRING")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Type of the funding source
        /// </summary>
        [DeserializeAs(Name = "TYPE")]
        public string Type { get; set; }
    }
}
