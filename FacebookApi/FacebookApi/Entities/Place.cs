using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Facebook place
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/place/"/>
    /// </summary>
    public class Place
    {
        /// <summary>
        /// ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// Location of Place
        /// </summary>
        [DeserializeAs(Name = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Overall Rating of Place, on a 5-star scale. 0 means not enough data to get a combined rating.
        /// </summary>
        [DeserializeAs(Name = "overall_rating")]
        public float OverallRating { get; set; }
    }
}
