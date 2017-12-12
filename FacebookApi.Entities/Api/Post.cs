using System;
using FacebookApi.Entities.Api;
using FacebookApi.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An individual entry in a profile's feed. The profile could be a user, page, app, or group.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/v2.5/post</para>
    /// </summary>
    public class Post : BaseEntity
    {
        /// <summary>
        /// The post ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }

        /// <summary>
        /// ID of admin, app or business that created the post. Applies to pages only
        /// </summary>
        [DeserializeAs(Name = "admin_creator")]
        [JsonProperty(PropertyName = "admin_creator", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AdminCreator { get; set; }

        /// <summary>
        /// Information about the app this post was published by.
        /// </summary>
        [DeserializeAs(Name = "application")]
        [JsonProperty(PropertyName = "application", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Application { get; set; }

        /// <summary>
        /// The call to action type used in any Page posts for mobile app engagement ads.
        /// </summary>
        [DeserializeAs(Name = "call_to_action")]
        [JsonProperty(PropertyName = "call_to_action", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PostCallToAction CallToAction { get; set; }

        /// <summary>
        /// The caption of a link in the post (appears beneath the name).
        /// </summary>
        [DeserializeAs(Name = "caption")]
        [JsonProperty(PropertyName = "caption", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Caption { get; set; }

        /// <summary>
        /// The time the post was initially published. For a post about a life event, this will be the date and time of the life event
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// A description of a link in the post (appears beneath the caption).
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// Object that controls news feed targeting for this post. Anyone in these groups will be more likely to see this post, others will be less likely, but may still see it anyway. Any of the targeting fields shown here can be used, none are required (applies to Pages only).
        /// </summary>
        [DeserializeAs(Name = "feed_targeting")]
        [JsonProperty(PropertyName = "feed_targeting", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FeedTargeting { get; set; }

        /// <summary>
        /// Information about the profile that posted the message.
        /// </summary>
        [DeserializeAs(Name = "from")]
        [JsonProperty(PropertyName = "from", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string From { get; set; }

        /// <summary>
        /// A link to an icon representing the type of this post.
        /// </summary>
        [DeserializeAs(Name = "icon")]
        [JsonProperty(PropertyName = "icon", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Icon { get; set; }

        /// <summary>
        /// If this post is marked as hidden (applies to Pages only).
        /// </summary>
        [DeserializeAs(Name = "is_hidden")]
        [JsonProperty(PropertyName = "is_hidden", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string IsHidden { get; set; }

        /// <summary>
        /// Indicates whether a scheduled post was published (applies to scheduled Page Post only, for users post and instanlty published posts this value is always true)
        /// </summary>
        [DeserializeAs(Name = "is_published")]
        [JsonProperty(PropertyName = "is_published", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string IsPublished { get; set; }

        /// <summary>
        /// The link attached to this post.
        /// </summary>
        [DeserializeAs(Name = "link")]
        [JsonProperty(PropertyName = "link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Link { get; set; }

        /// <summary>
        /// The status message in the post.
        /// </summary>
        [DeserializeAs(Name = "message")]
        [JsonProperty(PropertyName = "message", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Message { get; set; }

        /// <summary>
        /// Profiles tagged in message. This is an object with a unique key for each tag in the message
        /// </summary>
        [DeserializeAs(Name = "message_tags")]
        [JsonProperty(PropertyName = "message_tags", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MessageTags { get; set; }

        /// <summary>
        /// The name of the link.
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of any uploaded photo or video attached to the post.
        /// </summary>
        [DeserializeAs(Name = "object_id")]
        [JsonProperty(PropertyName = "object_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ObjectId { get; set; }

        /// <summary>
        /// The picture scraped from any link included with the post.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        [JsonProperty(PropertyName = "picture", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Picture { get; set; }

        /// <summary>
        /// Any location information attached to the post.
        /// </summary>
        [DeserializeAs(Name = "place")]
        [JsonProperty(PropertyName = "place", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Place { get; set; }

        /// <summary>
        /// The privacy settings of the post
        /// </summary>
        [DeserializeAs(Name = "privacy")]
        [JsonProperty(PropertyName = "privacy", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Privacy { get; set; }

        /// <summary>
        /// A list of properties for any attached video, for example, the length of the video.
        /// </summary>
        [DeserializeAs(Name = "properties")]
        [JsonProperty(PropertyName = "properties", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Properties { get; set; }

        /// <summary>
        /// The shares count of this post.
        /// </summary>
        [DeserializeAs(Name = "shares")]
        [JsonProperty(PropertyName = "shares", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Shares { get; set; }

        /// <summary>
        /// A URL to any Flash movie or video file attached to the post.
        /// </summary>
        [DeserializeAs(Name = "source")]
        [JsonProperty(PropertyName = "source", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Source { get; set; }

        /// <summary>
        /// Description of the type of a status update.
        /// </summary>
        [DeserializeAs(Name = "status_type")]
        [JsonProperty(PropertyName = "status_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PostStatus Status { get; set; }

        /// <summary>
        /// Text from stories not intentionally generated by users, such as those generated when two people become friends, or when someone else posts on the person's wall.
        /// </summary>
        [DeserializeAs(Name = "story")]
        [JsonProperty(PropertyName = "story", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Story { get; set; }

        /// <summary>
        /// Deprecated field, same as message_tags.
        /// </summary>
        [DeserializeAs(Name = "story_tags")]
        [JsonProperty(PropertyName = "story_tags", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string StoryTags { get; set; }

        /// <summary>
        /// Object that limited the audience for this content. Anyone not in these demographics will not be able to view this content. This will not override any Page-level demographic restrictions that may be in place.
        /// </summary>
        [DeserializeAs(Name = "targeting")]
        [JsonProperty(PropertyName = "targeting", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Targeting { get; set; }

        /// <summary>
        /// Profiles mentioned or targeted in this post.
        /// </summary>
        [DeserializeAs(Name = "to")]
        [JsonProperty(PropertyName = "to", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string To { get; set; }

        /// <summary>
        /// A string indicating the object type of this post.
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public PostType Type { get; set; }

        /// <summary>
        /// The time when the post was created, last edited or the time of the last comment that was left on the post. For a post about a life event, this will be the date and time of the life event
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Profiles tagged as being 'with' the publisher of the post.
        /// </summary>
        [DeserializeAs(Name = "with_tags")]
        [JsonProperty(PropertyName = "with_tags", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string WithTags { get; set; }
    }
}
