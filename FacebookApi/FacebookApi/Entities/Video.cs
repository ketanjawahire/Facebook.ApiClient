using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Represents an individual video on Facebook.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/video/</para>
    /// </summary>
    public class Video
    {
        /// <summary>
        /// Accuracy of the backdated time.
        /// </summary>
        [DeserializeAs(Name = "backdated_time_granularity")]
        public string BackdatedTimeGranularity { get; set; }

        /// <summary>
        /// The content category of this video.
        /// </summary>
        [DeserializeAs(Name = "content_category")]
        public string ContentCategory { get; set; }

        /// <summary>
        /// The video ID.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// The time when the video post was created.
        /// </summary>
        [DeserializeAs(Name = "backdated_time")]
        public DateTime? BackdatedTime { get; set; }

        /// <summary>
        /// Whether the video is copyrighted.
        /// </summary>
        [DeserializeAs(Name = "copyrighted")]
        public bool? Copyrighted { get; set; }

        /// <summary>
        /// The time the video was initially published.
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The description of the video.
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The HTML element that may be embedded in a Web page to play the video
        /// </summary>
        [DeserializeAs(Name = "embed_html")]
        public string EmbedHTML { get; set; }

        /// <summary>
        /// Whether the video is embeddable.
        /// </summary>
        [DeserializeAs(Name = "embeddable")]
        public bool? Embeddable { get; set; }

        /// <summary>
        /// If this object has a place, the event associated with the place
        /// </summary>
        [DeserializeAs(Name = "event")]
        public Event Event { get; set; }

        /// <summary>
        /// The different formats of the video.
        /// </summary>
        [DeserializeAs(Name = "format")]
        public IList<VideoFormat> Format { get; set; }

        /// <summary>
        /// The profile that created the video.
        /// </summary>
        [DeserializeAs(Name = "from")]
        public string From { get; set; }

        /// <summary>
        /// The icon that Facebook displays when videos are published to the feed. 
        /// </summary>
        [DeserializeAs(Name = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Whether the video is eligible to be promoted on Instagram
        /// </summary>
        [DeserializeAs(Name = "is_instagram_eligible")]
        public bool? IsInstagramEligible { get; set; }

        /// <summary>
        /// Duration of this video.
        /// </summary>
        [DeserializeAs(Name = "length")]
        public float Length { get; set; }

        /// <summary>
        /// URL to the permalink page of the video.
        /// </summary>
        [DeserializeAs(Name = "permalink_url")]
        public string PermalinkURL { get; set; }

        /// <summary>
        /// The URL for the thumbnail picture of the video.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        public string Picture { get; set; }

        /// <summary>
        /// Location associated with the video, if any.
        /// </summary>
        [DeserializeAs(Name = "place")]
        public Place Place { get; set; }

        /// <summary>
        /// Privacy setting for the video.
        /// </summary>
        [DeserializeAs(Name = "privacy")]
        public Privacy Privacy { get; set; }

        /// <summary>
        /// Whether a post about this video is published.
        /// </summary>
        [DeserializeAs(Name = "published")]
        public bool Published { get; set; }

        /// <summary>
        /// The time that the video is scheduled to expire.
        /// </summary>
        [DeserializeAs(Name = "scheduled_publish_time")]
        public DateTime? SchedulePublishTime { get; set; }

        /// <summary>
        /// A URL to the raw, playable video file
        /// </summary>
        [DeserializeAs(Name = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Object describing the status attributes of a video.
        /// </summary>
        [DeserializeAs(Name = "status")]
        public VideoStatus Status { get; set; }

        /// <summary>
        /// The video title or caption.
        /// </summary>
        [DeserializeAs(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The last time the video or its caption was updated.
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        public DateTime? UpdatedTime { get; set; }
    }
}
