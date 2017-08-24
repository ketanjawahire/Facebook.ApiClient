using RestSharp.Deserializers;

namespace FacebookApi.Entities
{

    /// <summary>
    /// The call to action type used in any Page posts for mobile app engagement ads.
    /// </summary>
    public class PostCallToActionValue
    {
        /// <summary>
        /// Link
        /// </summary>
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }
    }
}
