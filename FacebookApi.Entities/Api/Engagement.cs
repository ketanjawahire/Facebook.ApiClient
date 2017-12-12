using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// This is an API that can deliver the same data as what's used to render social information contained in a like button
    /// <para>https://developers.facebook.com/docs/graph-api/reference/engagement/</para>
    /// </summary>
    public class Engagement : BaseEntity
    {
        /// <summary>
        /// Number of people who like this
        /// </summary>
        [DeserializeAs(Name = "count")]
        [JsonProperty(PropertyName = "count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Count { get; set; }

        /// <summary>
        /// Abbreviated string representation of count
        /// </summary>
        [DeserializeAs(Name = "count_string")]
        [JsonProperty(PropertyName = "count_string", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CountString { get; set; }

        /// <summary>
        /// Abbreviated string representation of count if the viewer likes the object
        /// </summary>
        [DeserializeAs(Name = "count_string_with_like")]
        [JsonProperty(PropertyName = "count_string_with_like", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CountStringWithLike { get; set; }

        /// <summary>
        /// Abbreviated string representation of count if the viewer does not like the object
        /// </summary>
        [DeserializeAs(Name = "count_string_without_like")]
        [JsonProperty(PropertyName = "count_string_without_like", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CountStringWithoutLike { get; set; }

        /// <summary>
        /// Text that the like button would currently display
        /// </summary>
        [DeserializeAs(Name = "social_sentence")]
        [JsonProperty(PropertyName = "social_sentence", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SocialSentence { get; set; }

        /// <summary>
        /// Text that the like button would display if the viewer likes the object
        /// </summary>
        [DeserializeAs(Name = "social_sentence_with_like")]
        [JsonProperty(PropertyName = "social_sentence_with_like", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SocialSentenceWithLike { get; set; }

        /// <summary>
        /// Text that the like button would display if the viewer does not like the object
        /// </summary>
        [DeserializeAs(Name = "social_sentence_without_like")]
        [JsonProperty(PropertyName = "social_sentence_without_like", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SocialSentenceWithoutLike { get; set; }
    }
}
