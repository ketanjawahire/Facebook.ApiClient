using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.ApiEngine
{
    /// <summary>
    /// Page cursors
    /// </summary>
    public class Cursors
    {
        /// <summary>
        /// Cursor for previous page
        /// </summary>
        [DeserializeAs(Name = "before")]
        public string Before { get; set; }

        /// <summary>
        /// Cursor for next page
        /// </summary>
        [DeserializeAs(Name = "after")]
        public string After { get; set; }

    }
}
