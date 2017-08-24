using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Date about when the entity represented by the Page was started
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-start-date/</para>
    /// </summary>
    public class PageStartDate
    {
        /// <summary>
        /// The start day of the entity
        /// </summary>
        [DeserializeAs(Name = "day")]
        public int Day { get; set; }

        /// <summary>
        /// The start month of the entity
        /// </summary>
        [DeserializeAs(Name = "month")]
        public int Month { get; set; }

        /// <summary>
        /// The start year of the entity
        /// </summary>
        [DeserializeAs(Name = "year")]
        public int Year { get; set; }
    }
}
