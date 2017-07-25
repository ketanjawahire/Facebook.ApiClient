using System;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Represents a Facebook event.
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/event/"/>
    /// </summary>
    public class Event
    {
        /// <summary>
        /// The event ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// Number of people attending the event
        /// </summary>
        [DeserializeAs(Name = "attending_count")]
        public long AttendingCount { get; set; }

        /// <summary>
        /// Can guests invite friends
        /// </summary>
        [DeserializeAs(Name = "can_guests_invite")]
        public bool CanGuestsInvite { get; set; }

        /// <summary>
        /// The category of the event   
        /// </summary>
        [DeserializeAs(Name = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Cover picture
        /// </summary>
        [DeserializeAs(Name = "cover")]
        public CoverPhoto Cover { get; set; }

        /// <summary>
        /// Number of people who declined the event
        /// </summary>
        [DeserializeAs(Name = "declined_count")]
        public long DeclinedCount { get; set; }

        /// <summary>
        /// Long-form description
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// End time, if one has been set
        /// </summary>
        [DeserializeAs(Name = "end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// Can see guest list
        /// </summary>
        [DeserializeAs(Name = "guest_list_enabled")]
        public bool GuestListEnabled { get; set; }

        /// <summary>
        /// Number of people interested in the event
        /// </summary>
        [DeserializeAs(Name = "interested_count")]
        public long InterestedCount { get; set; }

        /// <summary>
        /// Whether the event is created by page or not
        /// </summary>
        [DeserializeAs(Name = "is_page_owned")]
        public bool IsPageOwned { get; set; }

        /// <summary>
        /// Whether the viewer is admin or not
        /// </summary>
        [DeserializeAs(Name = "is_viewer_admin")]
        public bool IsViewerAdmin { get; set; }

        /// <summary>
        /// Number of people who maybe going to the event
        /// </summary>
        [DeserializeAs(Name = "maybe_count")]
        public long MaybeCount { get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Number of people who did not reply to the event
        /// </summary>
        [DeserializeAs(Name = "noreply_count")]
        public int NoreplyCount { get; set; }

        /// <summary>
        /// The profile that created the event
        /// </summary>
        [DeserializeAs(Name = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// The group the event belongs to
        /// </summary>
        [DeserializeAs(Name = "parent_group")]
        public Group ParentGroup { get; set; }

        /// <summary>
        /// Event Place information
        /// </summary>
        [DeserializeAs(Name = "place")]
        public Place Place { get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// The link users can visit to buy a ticket to this event
        /// </summary>
        [DeserializeAs(Name = "ticket_uri")]
        public string TicketUri { get; set; }

        /// <summary>
        /// Timezone
        /// </summary>
        [DeserializeAs(Name = "timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// The type of the event
        /// </summary>
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Last update time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        public DateTime? UpdatedTime { get; set; }
    }
}
