using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A Video Format
    /// <para>https://developers.facebook.com/docs/graph-api/reference/video-format/</para>
    /// </summary>
    public class VideoFormat : BaseEntity
    {
        /// <summary>
        /// HTML to embed the video in this format.
        /// </summary>
        [DeserializeAs(Name = "embed_html")]
        [JsonProperty(PropertyName = "embed_html", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EmbedHTML { get; set; }

        /// <summary>
        /// The filter applied to this video format.
        /// </summary>
        [DeserializeAs(Name = "filter")]
        [JsonProperty(PropertyName = "filter", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Filter { get; set; }

        /// <summary>
        /// The height of the video in this format.
        /// </summary>
        [DeserializeAs(Name = "height")]
        [JsonProperty(PropertyName = "height", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Height { get; set; }

        /// <summary>
        /// The thumbnail for the video in this format.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        [JsonProperty(PropertyName = "picture", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Picture { get; set; }

        /// <summary>
        /// The width of the video in this format.
        /// </summary>
        [DeserializeAs(Name = "width")]
        [JsonProperty(PropertyName = "width", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Width { get; set; }
    }
}
