using FacebookApi.Entities.Enumerations;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Status attributes of video
    /// <para>https://developers.facebook.com/docs/graph-api/reference/video-status/</para>
    /// </summary>
    public class VideoStatus
    {
        /// <summary>
        /// Video processing progress in percent [int 0 to 100].
        /// </summary>
        [DeserializeAs(Name = "processing_progress")]
        public int ProcessingProgress { get; set; }

        /// <summary>
        /// Status of a video
        /// </summary>
        [DeserializeAs(Name = "video_status")]
        public VideoProcessingStatus Status { get; set; }
    }
}
