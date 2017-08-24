using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Information about when a business was started that's represented by a Facebook Page
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page-start-info/</para>
    /// </summary>
    public class PageStartInfo
    {
        /// <summary>
        /// The start date of the entity
        /// </summary>
        [DeserializeAs(Name = "date")]
        public PageStartDate Date { get; set; }

        /// <summary>
        /// The start type of the entity
        /// </summary>
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }
    }
}
