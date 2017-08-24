using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Data defining a text page post used for an ad.
    /// </summary>
    public class AdCreativeTextData
    {
        /// <summary>
        /// The text of the page post.
        /// </summary>
        [DeserializeAs(Name = "message")]
        public string Message { get; set; }
    }
}
