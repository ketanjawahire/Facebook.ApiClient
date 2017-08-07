using FacebookApi.Interfaces.IApiEngine;
using RestSharp.Deserializers;

namespace FacebookApi.ApiEngine
{
    /// <summary>
    /// Represents paging object
    /// </summary>
    public class Paging : IPaging
    {
        
        /// <summary>
        /// Next page url
        /// </summary>
        [DeserializeAs(Name = "next")]
        public string Next { get; set; }

        /// <summary>
        /// Previous page url
        /// </summary>
        [DeserializeAs(Name = "previous")]
        public string Previous { get; set; }

        [DeserializeAs(Name = "cursors")]
        public Cursors Cursors { get; set; }
    }

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
