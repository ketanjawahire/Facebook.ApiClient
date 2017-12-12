using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specification for an offline offer ad.
    /// </summary>
    public class AdCreativeOfferData : BaseEntity
    {
        /// <summary>
        /// The maximum number of times the offer can be claimed
        /// </summary>
        [DeserializeAs(Name = "claim_limit")]
        [JsonProperty(PropertyName = "claim_limit", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int ClaimLimit { get; set; }

        /// <summary>
        /// The type of offer: in_store_only or in_store_and_online.
        /// </summary>
        [DeserializeAs(Name = "coupon_type")]
        [JsonProperty(PropertyName = "coupon_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CouponType { get; set; }

        /// <summary>
        /// The expiration time of the offer (used when displaying the offer).
        /// </summary>
        [DeserializeAs(Name = "expiration_time")]
        [JsonProperty(PropertyName = "expiration_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// The URL for the offer's image.
        /// </summary>
        [DeserializeAs(Name = "image_url")]
        [JsonProperty(PropertyName = "image_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The body text of the offer.
        /// </summary>
        [DeserializeAs(Name = "message")]
        [JsonProperty(PropertyName = "message", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Message { get; set; }

        /// <summary>
        /// The URL where the offer may be redeemed.
        /// </summary>
        [DeserializeAs(Name = "redemption_link")]
        [JsonProperty(PropertyName = "redemption_link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string RedemptionLink { get; set; }

        /// <summary>
        /// Time before the expiration_time of the offer when the user receives a notification that the offer is about to expire
        /// </summary>
        [DeserializeAs(Name = "reminder_time")]
        [JsonProperty(PropertyName = "reminder_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ReminderTime { get; set; }

        /// <summary>
        /// The title of the offer.
        /// </summary>
        [DeserializeAs(Name = "title")]
        [JsonProperty(PropertyName = "title", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Title { get; set; }

    }
}
