using System;
using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Represents an individual video on Facebook.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/video/</para>
    /// </summary>
    public class Video : BaseEntity
    {
        /// <summary>
        /// Accuracy of the backdated time.
        /// </summary>
        [DeserializeAs(Name = "backdated_time_granularity")]
        [JsonProperty(PropertyName = "backdated_time_granularity", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string BackdatedTimeGranularity { get; set; }

        /// <summary>
        /// The content category of this video.
        /// </summary>
        [DeserializeAs(Name = "content_category")]
        [JsonProperty(PropertyName = "content_category", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ContentCategory { get; set; }

        /// <summary>
        /// The video ID.
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// The time when the video post was created.
        /// </summary>
        [DeserializeAs(Name = "backdated_time")]
        [JsonProperty(PropertyName = "backdated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? BackdatedTime { get; set; }

        /// <summary>
        /// Whether the video is copyrighted.
        /// </summary>
        [DeserializeAs(Name = "copyrighted")]
        [JsonProperty(PropertyName = "copyrighted", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? Copyrighted { get; set; }

        /// <summary>
        /// The time the video was initially published.
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The description of the video.
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// The HTML element that may be embedded in a Web page to play the video
        /// </summary>
        [DeserializeAs(Name = "embed_html")]
        [JsonProperty(PropertyName = "embed_html", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EmbedHTML { get; set; }

        /// <summary>
        /// Whether the video is embeddable.
        /// </summary>
        [DeserializeAs(Name = "embeddable")]
        [JsonProperty(PropertyName = "embeddable", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? Embeddable { get; set; }

        /// <summary>
        /// If this object has a place, the event associated with the place
        /// </summary>
        [DeserializeAs(Name = "event")]
        [JsonProperty(PropertyName = "event", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Event Event { get; set; }

        /// <summary>
        /// The different formats of the video.
        /// </summary>
        [DeserializeAs(Name = "format")]
        [JsonProperty(PropertyName = "format", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<VideoFormat> Format { get; set; }

        /// <summary>
        /// The profile that created the video.
        /// </summary>
        [DeserializeAs(Name = "from")]
        [JsonProperty(PropertyName = "from", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string From { get; set; }

        /// <summary>
        /// The icon that Facebook displays when videos are published to the feed. 
        /// </summary>
        [DeserializeAs(Name = "icon")]
        [JsonProperty(PropertyName = "icon", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Icon { get; set; }

        /// <summary>
        /// Whether the video is eligible to be promoted on Instagram
        /// </summary>
        [DeserializeAs(Name = "is_instagram_eligible")]
        [JsonProperty(PropertyName = "is_instagram_eligible", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsInstagramEligible { get; set; }

        /// <summary>
        /// Duration of this video.
        /// </summary>
        [DeserializeAs(Name = "length")]
        [JsonProperty(PropertyName = "length", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float Length { get; set; }

        /// <summary>
        /// URL to the permalink page of the video.
        /// </summary>
        [DeserializeAs(Name = "permalink_url")]
        [JsonProperty(PropertyName = "permalink_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PermalinkURL { get; set; }

        /// <summary>
        /// The URL for the thumbnail picture of the video.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        [JsonProperty(PropertyName = "picture", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Picture { get; set; }

        /// <summary>
        /// Location associated with the video, if any.
        /// </summary>
        [DeserializeAs(Name = "place")]
        [JsonProperty(PropertyName = "place", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Place Place { get; set; }

        /// <summary>
        /// Privacy setting for the video.
        /// </summary>
        [DeserializeAs(Name = "privacy")]
        [JsonProperty(PropertyName = "privacy", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Privacy Privacy { get; set; }

        /// <summary>
        /// Whether a post about this video is published.
        /// </summary>
        [DeserializeAs(Name = "published")]
        [JsonProperty(PropertyName = "published", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool Published { get; set; }

        /// <summary>
        /// The time that the video is scheduled to expire.
        /// </summary>
        [DeserializeAs(Name = "scheduled_publish_time")]
        [JsonProperty(PropertyName = "scheduled_publish_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? SchedulePublishTime { get; set; }

        /// <summary>
        /// A URL to the raw, playable video file
        /// </summary>
        [DeserializeAs(Name = "source")]
        [JsonProperty(PropertyName = "source", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Source { get; set; }

        /// <summary>
        /// Object describing the status attributes of a video.
        /// </summary>
        [DeserializeAs(Name = "status")]
        [JsonProperty(PropertyName = "status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public VideoStatus Status { get; set; }

        /// <summary>
        /// The video title or caption.
        /// </summary>
        [DeserializeAs(Name = "title")]
        [JsonProperty(PropertyName = "title", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Title { get; set; }

        /// <summary>
        /// The last time the video or its caption was updated.
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? UpdatedTime { get; set; }
    }
}
