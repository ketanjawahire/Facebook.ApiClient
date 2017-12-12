using FacebookApi.Entities.Api;
using FacebookApi.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Status attributes of video
    /// <para>https://developers.facebook.com/docs/graph-api/reference/video-status/</para>
    /// </summary>
    public class VideoStatus : BaseEntity
    {
        /// <summary>
        /// Video processing progress in percent [int 0 to 100].
        /// </summary>
        [DeserializeAs(Name = "processing_progress")]
        [JsonProperty(PropertyName = "processing_progress", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int ProcessingProgress { get; set; }

        /// <summary>
        /// Status of a video
        /// </summary>
        [DeserializeAs(Name = "video_status")]
        [JsonProperty(PropertyName = "video_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public VideoProcessingStatus Status { get; set; }
    }
}
