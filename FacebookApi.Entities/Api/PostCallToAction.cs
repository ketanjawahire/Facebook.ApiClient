using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The call to action type used in any Page posts for mobile app engagement ads.
    /// </summary>
    public class PostCallToAction
    {
        /// <summary>
        /// Type
        /// </summary>
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [DeserializeAs(Name = "value")]
        public PostCallToActionValue Value { get; set; }
    }
}
