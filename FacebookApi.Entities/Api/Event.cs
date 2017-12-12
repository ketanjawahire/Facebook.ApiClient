using System;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Represents a Facebook event.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/event/</para>
    /// </summary>
    public class Event : BaseEntity
    {
        /// <summary>
        /// The event ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Id { get; set; }

        /// <summary>
        /// Number of people attending the event
        /// </summary>
        [DeserializeAs(Name = "attending_count")]
        [JsonProperty(PropertyName = "attending_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long AttendingCount { get; set; }

        /// <summary>
        /// Can guests invite friends
        /// </summary>
        [DeserializeAs(Name = "can_guests_invite")]
        [JsonProperty(PropertyName = "can_guests_invite", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool CanGuestsInvite { get; set; }

        /// <summary>
        /// The category of the event   
        /// </summary>
        [DeserializeAs(Name = "category")]
        [JsonProperty(PropertyName = "category", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Category { get; set; }

        /// <summary>
        /// Cover picture
        /// </summary>
        [DeserializeAs(Name = "cover")]
        [JsonProperty(PropertyName = "cover", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CoverPhoto Cover { get; set; }

        /// <summary>
        /// Number of people who declined the event
        /// </summary>
        [DeserializeAs(Name = "declined_count")]
        [JsonProperty(PropertyName = "declined_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long DeclinedCount { get; set; }

        /// <summary>
        /// Long-form description
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// End time, if one has been set
        /// </summary>
        [DeserializeAs(Name = "end_time")]
        [JsonProperty(PropertyName = "end_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EndTime { get; set; }

        /// <summary>
        /// Can see guest list
        /// </summary>
        [DeserializeAs(Name = "guest_list_enabled")]
        [JsonProperty(PropertyName = "guest_list_enabled", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool GuestListEnabled { get; set; }

        /// <summary>
        /// Number of people interested in the event
        /// </summary>
        [DeserializeAs(Name = "interested_count")]
        [JsonProperty(PropertyName = "interested_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long InterestedCount { get; set; }

        /// <summary>
        /// Whether the event is created by page or not
        /// </summary>
        [DeserializeAs(Name = "is_page_owned")]
        [JsonProperty(PropertyName = "is_page_owned", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsPageOwned { get; set; }

        /// <summary>
        /// Whether the viewer is admin or not
        /// </summary>
        [DeserializeAs(Name = "is_viewer_admin")]
        [JsonProperty(PropertyName = "is_viewer_admin", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsViewerAdmin { get; set; }

        /// <summary>
        /// Number of people who maybe going to the event
        /// </summary>
        [DeserializeAs(Name = "maybe_count")]
        [JsonProperty(PropertyName = "maybe_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long MaybeCount { get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Number of people who did not reply to the event
        /// </summary>
        [DeserializeAs(Name = "noreply_count")]
        [JsonProperty(PropertyName = "noreply_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int NoreplyCount { get; set; }

        /// <summary>
        /// The profile that created the event
        /// </summary>
        [DeserializeAs(Name = "owner")]
        [JsonProperty(PropertyName = "owner", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Owner { get; set; }

        /// <summary>
        /// The group the event belongs to
        /// </summary>
        [DeserializeAs(Name = "parent_group")]
        [JsonProperty(PropertyName = "parent_group", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Group ParentGroup { get; set; }

        /// <summary>
        /// Event Place information
        /// </summary>
        [DeserializeAs(Name = "place")]
        [JsonProperty(PropertyName = "place", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Place Place { get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        [JsonProperty(PropertyName = "start_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string StartTime { get; set; }

        /// <summary>
        /// The link users can visit to buy a ticket to this event
        /// </summary>
        [DeserializeAs(Name = "ticket_uri")]
        [JsonProperty(PropertyName = "ticket_uri", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TicketUri { get; set; }

        /// <summary>
        /// Timezone
        /// </summary>
        [DeserializeAs(Name = "timezone")]
        [JsonProperty(PropertyName = "timezone", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Timezone { get; set; }

        /// <summary>
        /// The type of the event
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }

        /// <summary>
        /// Last update time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? UpdatedTime { get; set; }
    }
}
