using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Funding Source Details
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-account/</para>
    /// </summary>
    public class FundingSourceDetails : BaseEntity
    {
        /// <summary>
        /// ID of the payment method
        /// </summary>
        [DeserializeAs(Name = "ID")]
        [JsonProperty(PropertyName = "ID", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }

        /// <summary>
        /// Details of the Facebook Ads Coupon from the payment method
        /// </summary>
        [DeserializeAs(Name = "COUPON")]
        [JsonProperty(PropertyName = "COUPON", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Coupon { get; set; }

        /// <summary>
        /// Amount of Facebook Ads Coupon
        /// </summary>
        [DeserializeAs(Name = "AMOUNT")]
        [JsonProperty(PropertyName = "AMOUNT", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Amount { get; set; }

        /// <summary>
        /// Currency of the Facebook Ads Coupon
        /// </summary>
        [DeserializeAs(Name = "CURRENCY")]
        [JsonProperty(PropertyName = "CURRENCY", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Currency { get; set; }

        /// <summary>
        /// How the amount of Facebook Ads Coupon is displayed
        /// </summary>
        [DeserializeAs(Name = "DISPLAY_AMOUNT")]
        [JsonProperty(PropertyName = "DISPLAY_AMOUNT", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DisplayAmount { get; set; }

        /// <summary>
        /// When the coupon will expire
        /// </summary>
        [DeserializeAs(Name = "EXPIRATION")]
        [JsonProperty(PropertyName = "EXPIRATION", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Expiration { get; set; }

        /// <summary>
        ///  How the payment method is shown
        /// </summary>
        [DeserializeAs(Name = "DISPLAY_STRING")]
        [JsonProperty(PropertyName = "DISPLAY_STRING", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DisplayString { get; set; }

        /// <summary>
        /// Type of the funding source
        /// </summary>
        [DeserializeAs(Name = "TYPE")]
        [JsonProperty(PropertyName = "TYPE", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }
    }
}
