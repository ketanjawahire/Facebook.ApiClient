using System;
using FacebookApi.Enums;
using FacebookApi.Enums.Api;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An individual entry in a profile's feed. The profile could be a user, page, app, or group.
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/v2.5/post"/>
    /// </summary>
    public class Post
    {
        /// <summary>
        /// The post ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of admin, app or business that created the post. Applies to pages only
        /// </summary>
        [DeserializeAs(Name = "admin_creator")]
        public string AdminCreator { get; set; }

        /// <summary>
        /// Information about the app this post was published by.
        /// </summary>
        [DeserializeAs(Name = "application")]
        public string Application { get; set; }

        /// <summary>
        /// The call to action type used in any Page posts for mobile app engagement ads.
        /// </summary>
        [DeserializeAs(Name = "call_to_action")]
        public PostCallToAction CallToAction { get; set; }

        /// <summary>
        /// The caption of a link in the post (appears beneath the name).
        /// </summary>
        [DeserializeAs(Name = "caption")]
        public string Caption { get; set; }

        /// <summary>
        /// The time the post was initially published. For a post about a life event, this will be the date and time of the life event
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// A description of a link in the post (appears beneath the caption).
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Object that controls news feed targeting for this post. Anyone in these groups will be more likely to see this post, others will be less likely, but may still see it anyway. Any of the targeting fields shown here can be used, none are required (applies to Pages only).
        /// </summary>
        [DeserializeAs(Name = "feed_targeting")]
        public string FeedTargeting { get; set; }

        /// <summary>
        /// Information about the profile that posted the message.
        /// </summary>
        [DeserializeAs(Name = "from")]
        public string From { get; set; }

        /// <summary>
        /// A link to an icon representing the type of this post.
        /// </summary>
        [DeserializeAs(Name = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// If this post is marked as hidden (applies to Pages only).
        /// </summary>
        [DeserializeAs(Name = "is_hidden")]
        public string IsHidden { get; set; }

        /// <summary>
        /// Indicates whether a scheduled post was published (applies to scheduled Page Post only, for users post and instanlty published posts this value is always true)
        /// </summary>
        [DeserializeAs(Name = "is_published")]
        public string IsPublished { get; set; }

        /// <summary>
        /// The link attached to this post.
        /// </summary>
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The status message in the post.
        /// </summary>
        [DeserializeAs(Name = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Profiles tagged in message. This is an object with a unique key for each tag in the message
        /// </summary>
        [DeserializeAs(Name = "message_tags")]
        public string MessageTags { get; set; }

        /// <summary>
        /// The name of the link.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The ID of any uploaded photo or video attached to the post.
        /// </summary>
        [DeserializeAs(Name = "object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// The picture scraped from any link included with the post.
        /// </summary>
        [DeserializeAs(Name = "picture")]
        public string Picture { get; set; }

        /// <summary>
        /// Any location information attached to the post.
        /// </summary>
        [DeserializeAs(Name = "place")]
        public string Place { get; set; }

        /// <summary>
        /// The privacy settings of the post
        /// </summary>
        [DeserializeAs(Name = "privacy")]
        public string Privacy { get; set; }

        /// <summary>
        /// A list of properties for any attached video, for example, the length of the video.
        /// </summary>
        [DeserializeAs(Name = "properties")]
        public string Properties { get; set; }

        /// <summary>
        /// The shares count of this post.
        /// </summary>
        [DeserializeAs(Name = "shares")]
        public string Shares { get; set; }

        /// <summary>
        /// A URL to any Flash movie or video file attached to the post.
        /// </summary>
        [DeserializeAs(Name = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Description of the type of a status update.
        /// </summary>
        [DeserializeAs(Name = "status_type")]
        public PostStatus Status { get; set; }

        /// <summary>
        /// Text from stories not intentionally generated by users, such as those generated when two people become friends, or when someone else posts on the person's wall.
        /// </summary>
        [DeserializeAs(Name = "story")]
        public string Story { get; set; }

        /// <summary>
        /// Deprecated field, same as message_tags.
        /// </summary>
        [DeserializeAs(Name = "story_tags")]
        public string StoryTags { get; set; }

        /// <summary>
        /// Object that limited the audience for this content. Anyone not in these demographics will not be able to view this content. This will not override any Page-level demographic restrictions that may be in place.
        /// </summary>
        [DeserializeAs(Name = "targeting")]
        public string Targeting { get; set; }

        /// <summary>
        /// Profiles mentioned or targeted in this post.
        /// </summary>
        [DeserializeAs(Name = "to")]
        public string To { get; set; }

        /// <summary>
        /// A string indicating the object type of this post.
        /// </summary>
        [DeserializeAs(Name = "type")]
        public PostType Type { get; set; }

        /// <summary>
        /// The time when the post was created, last edited or the time of the last comment that was left on the post. For a post about a life event, this will be the date and time of the life event
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Profiles tagged as being 'with' the publisher of the post.
        /// </summary>
        [DeserializeAs(Name = "with_tags")]
        public string WithTags { get; set; }
    }
}
