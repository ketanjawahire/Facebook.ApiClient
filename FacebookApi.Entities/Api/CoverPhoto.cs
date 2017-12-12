using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A cover photo for objects in the Graph API. Cover photos are used with Events, Groups, Pages and People
    /// <para>https://developers.facebook.com/docs/graph-api/reference/cover-photo/</para>
    /// </summary>
    public class CoverPhoto : BaseEntity
    {
        /// <summary>
        /// The ID of the cover photo
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Id { get; set; }

        /// <summary>
        /// The value represents the horizontal manual offset (the amount the user dragged the photo horizontally to show the part of interest) as a percentage of the offset necessary to make the photo fit the space.
        /// </summary>
        [DeserializeAs(Name = "offset_x")]
        [JsonProperty(PropertyName = "offset_x", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float? OffsetX { get; set; }

        /// <summary>
        /// The value represents the vertical manual offset (the amount the user dragged the photo vertically to show the part of interest) as a percentage of the offset necessary to make the photo fit the space.
        /// </summary>
        [DeserializeAs(Name = "offset_y")]
        [JsonProperty(PropertyName = "offset_y", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float? OffsetY { get; set; }

        /// <summary>
        /// Direct URL for the person's cover photo image
        /// </summary>
        [DeserializeAs(Name = "source")]
        [JsonProperty(PropertyName = "source", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Source { get; set; }
    }
}
