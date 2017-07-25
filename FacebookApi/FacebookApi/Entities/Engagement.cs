using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// This is an API that can deliver the same data as what's used to render social information contained in a like button
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/engagement/"/>
    /// </summary>
    public class Engagement
    {
        /// <summary>
        /// Number of people who like this
        /// </summary>
        [DeserializeAs(Name = "count")]
        public int Count { get; set; }
        
        /// <summary>
        /// Abbreviated string representation of count
        /// </summary>
        [DeserializeAs(Name = "count_string")]
        public string CountString { get; set; }

        /// <summary>
        /// Abbreviated string representation of count if the viewer likes the object
        /// </summary>
        [DeserializeAs(Name = "count_string_with_like")]
        public string CountStringWithLike { get; set; }

        /// <summary>
        /// Abbreviated string representation of count if the viewer does not like the object
        /// </summary>
        [DeserializeAs(Name = "count_string_without_like")]
        public string CountStringWithoutLike { get; set; }

        /// <summary>
        /// Text that the like button would currently display
        /// </summary>
        [DeserializeAs(Name = "social_sentence")]
        public string SocialSentence { get; set; }

        /// <summary>
        /// Text that the like button would display if the viewer likes the object
        /// </summary>
        [DeserializeAs(Name = "social_sentence_with_like")]
        public string SocialSentenceWithLike { get; set; }

        /// <summary>
        /// Text that the like button would display if the viewer does not like the object
        /// </summary>
        [DeserializeAs(Name = "social_sentence_without_like")]
        public string SocialSentenceWithoutLike { get; set; }
    }
}
