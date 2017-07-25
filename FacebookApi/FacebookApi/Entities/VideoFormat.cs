using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A Video Format
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/video-format/"/>
    /// </summary>
    public class VideoFormat
    {
        /// <summary>
        /// HTML to embed the video in this format.
        /// </summary>
        [DeserializeAs(Name = "embed_html")]
        public string EmbedHTML { get; set; }

        /// <summary>
        /// The filter applied to this video format.
        /// </summary>
        [DeserializeAs(Name = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// The height of the video in this format.
        /// </summary>
        [DeserializeAs(Name = "height")]
        public int Height { get; set; }

        /// <summary>
        /// The thumbnail for the video in this format.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        public string Picture { get; set; }

        /// <summary>
        /// The width of the video in this format.
        /// </summary>
        [DeserializeAs(Name = "width")]
        public int Width { get; set; }
    }
}
