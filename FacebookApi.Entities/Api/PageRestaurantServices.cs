using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Services that a Resturant that's represented as a Facebook Page might provide
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-restaurant-services/</para>
    /// </summary>
    public class PageRestaurantServices
    {
        /// <summary>
        /// Whether the restaurant has catering service
        /// </summary>
        [DeserializeAs(Name = "catering")]
        public int Catering { get; set; }

        /// <summary>
        /// Whether the restaurant has delivery service
        /// </summary>
        [DeserializeAs(Name = "delivery")]
        public int Delivery { get; set; }

        /// <summary>
        /// Whether the restaurant is group-friendly
        /// </summary>
        [DeserializeAs(Name = "groups")]
        public int Groups { get; set; }

        /// <summary>
        /// Whether the restaurant is kids-friendly
        /// </summary>
        [DeserializeAs(Name = "kids")]
        public int Kids { get; set; }

        /// <summary>
        /// Whether the restaurant has outdoor seating
        /// </summary>
        [DeserializeAs(Name = "outdoor")]
        public int Outdoor { get; set; }

        /// <summary>
        /// Whether the restaurant takes reservations
        /// </summary>
        [DeserializeAs(Name = "reserve")]
        public int Reserve { get; set; }

        /// <summary>
        /// Whether the restaurant has takeout service
        /// </summary>
        [DeserializeAs(Name = "takeout")]
        public int Takeout { get; set; }

        /// <summary>
        /// Whether the restaurant has waiters
        /// </summary>
        [DeserializeAs(Name = "waiter")]
        public int Waiter { get; set; }

        /// <summary>
        /// Whether the restaurant welcomes walkins
        /// </summary>
        [DeserializeAs(Name = "walkins")]
        public int Walkins { get; set; }
    }
}
