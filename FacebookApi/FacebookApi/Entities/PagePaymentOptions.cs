using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Page payment options in the Graph API.
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/page-payment-options/"/>
    /// </summary>
    public class PagePaymentOptions
    {
        /// <summary>
        /// Whether the business accepts American Express as a payment option
        /// </summary>
        [DeserializeAs(Name = "amex")]
        public int Amex { get; set; }

        /// <summary>
        /// Whether the business accepts cash only as a payment option
        /// </summary>
        [DeserializeAs(Name = "cash_only")]
        public int CashOnly { get; set; }

        /// <summary>
        /// Whether the business accepts Discover as a payment option
        /// </summary>
        [DeserializeAs(Name = "discover")]
        public int Discover { get; set; }

        /// <summary>
        /// Whether the business accepts MasterCard as a payment option
        /// </summary>
        [DeserializeAs(Name = "mastercard")]
        public int MasterCard { get; set; }

        /// <summary>
        /// Whether the business accepts Visa as a payment option
        /// </summary>
        [DeserializeAs(Name = "visa")]
        public int Visa { get; set; }
    }
}
