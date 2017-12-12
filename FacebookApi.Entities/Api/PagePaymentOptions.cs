using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Page payment options in the Graph API.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-payment-options/</para>
    /// </summary>
    public class PagePaymentOptions : BaseEntity
    {
        /// <summary>
        /// Whether the business accepts American Express as a payment option
        /// </summary>
        [DeserializeAs(Name = "amex")]
        [JsonProperty(PropertyName = "amex", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Amex { get; set; }

        /// <summary>
        /// Whether the business accepts cash only as a payment option
        /// </summary>
        [DeserializeAs(Name = "cash_only")]
        [JsonProperty(PropertyName = "cash_only", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int CashOnly { get; set; }

        /// <summary>
        /// Whether the business accepts Discover as a payment option
        /// </summary>
        [DeserializeAs(Name = "discover")]
        [JsonProperty(PropertyName = "discover", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Discover { get; set; }

        /// <summary>
        /// Whether the business accepts MasterCard as a payment option
        /// </summary>
        [DeserializeAs(Name = "mastercard")]
        [JsonProperty(PropertyName = "mastercard", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int MasterCard { get; set; }

        /// <summary>
        /// Whether the business accepts Visa as a payment option
        /// </summary>
        [DeserializeAs(Name = "visa")]
        [JsonProperty(PropertyName = "visa", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Visa { get; set; }
    }
}
