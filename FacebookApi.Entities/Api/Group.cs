using System;
using FacebookApi.Entities.Api;
using FacebookApi.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Represents a Facebook group. 
    /// <para>https://developers.facebook.com/docs/graph-api/reference/v2.5/group</para>
    /// </summary>
    public class Group : BaseEntity
    {
        /// <summary>
        /// The group ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Id { get; set; }

        /// <summary>
        /// Information about the group's cover photo.
        /// </summary>
        [DeserializeAs(Name = "cover")]
        [JsonProperty(PropertyName = "cover", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CoverPhoto Cover { get; set; }

        /// <summary>
        /// A brief description of the group.
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// The email address to upload content to the group. Only current members of the group can use this.
        /// </summary>
        [DeserializeAs(Name = "email")]
        [JsonProperty(PropertyName = "email", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Email { get; set; }

        /// <summary>
        /// The URL for the group's icon.
        /// </summary>
        [DeserializeAs(Name = "icon")]
        [JsonProperty(PropertyName = "icon", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Icon { get; set; }

        /// <summary>
        /// The group's website.
        /// </summary>
        [DeserializeAs(Name = "link")]
        [JsonProperty(PropertyName = "link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Link { get; set; }

        /// <summary>
        /// The number of pending member requests.
        /// </summary>
        [DeserializeAs(Name = "member_request_count")]
        [JsonProperty(PropertyName = "member_request_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int MemberRequestCount { get; set; }

        /// <summary>
        /// The name of the group.
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// The privacy setting of the group. 
        /// </summary>
        [DeserializeAs(Name = "privacy")]
        [JsonProperty(PropertyName = "privacy", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public GroupPrivacy? Privacy { get; set; }

        /// <summary>
        /// The last time the group was updated
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? UpdatedTime { get; set; }
    }
}
