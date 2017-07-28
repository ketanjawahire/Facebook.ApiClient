using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Specialties of a restaurant that is represented by a Facebook Page
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-restaurant-specialties/</para>
    /// </summary>
    public class PageRestaurantSpecialties
    {
        /// <summary>
        /// Whether the restaurant serves breakfast
        /// </summary>
        [DeserializeAs(Name = "breakfast")]
        public int Breakfast { get; set; }

        /// <summary>
        /// Whether the restaurant serves coffee
        /// </summary>
        [DeserializeAs(Name = "coffee")]
        public int Coffee { get; set; }

        /// <summary>
        /// Whether the restaurant serves dinner
        /// </summary>
        [DeserializeAs(Name = "dinner")]
        public int Dinner { get; set; }

        /// <summary>
        /// Whether the restaurant serves drinks
        /// </summary>
        [DeserializeAs(Name = "drinks")]
        public int Drinks { get; set; }

        /// <summary>
        /// Whether the restaurant serves lunch
        /// </summary>
        [DeserializeAs(Name = "lunch")]
        public int Lunch { get; set; }
    }
}
