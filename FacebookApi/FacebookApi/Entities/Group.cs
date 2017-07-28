using System;
using FacebookApi.Enums;
using FacebookApi.Enums.Api;
using FacebookApi.Interfaces;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Represents a Facebook group. 
    /// <para>https://developers.facebook.com/docs/graph-api/reference/v2.5/group</para>
    /// </summary>
    public class Group
    {
        /// <summary>
        /// The group ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// Information about the group's cover photo.
        /// </summary>
        [DeserializeAs(Name = "cover")]
        public CoverPhoto Cover { get; set; }

        /// <summary>
        /// A brief description of the group.
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The email address to upload content to the group. Only current members of the group can use this.
        /// </summary>
        [DeserializeAs(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The URL for the group's icon.
        /// </summary>
        [DeserializeAs(Name = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// The group's website.
        /// </summary>
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The number of pending member requests.
        /// </summary>
        [DeserializeAs(Name = "member_request_count")]
        public int MemberRequestCount { get; set; }

        /// <summary>
        /// The name of the group.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The privacy setting of the group. 
        /// </summary>
        [DeserializeAs(Name = "privacy")]
        public GroupPrivacy? Privacy { get; set; }

        /// <summary>
        /// The last time the group was updated
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        public DateTime? UpdatedTime { get; set; }
    }
}
