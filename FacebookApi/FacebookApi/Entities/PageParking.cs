using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Parking options for a Page.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-parking/</para>
    /// </summary>
    public class PageParking
    {
        /// <summary>
        /// Whether lot parking is available
        /// </summary>
        [DeserializeAs(Name = "lot")]
        public int Lot { get; set; }

        /// <summary>
        /// Whether street parking is available
        /// </summary>
        [DeserializeAs(Name = "street")]
        public int Street { get; set; }

        /// <summary>
        /// Whether valet parking is available
        /// </summary>
        [DeserializeAs(Name = "valet")]
        public int Valet { get; set; }
    }
}
