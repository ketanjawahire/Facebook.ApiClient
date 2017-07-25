using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A cover photo for objects in the Graph API. Cover photos are used with Events, Groups, Pages and People
    /// <para>https://developers.facebook.com/docs/graph-api/reference/cover-photo/</para>
    /// </summary>
    public class CoverPhoto
    {
        /// <summary>
        /// The ID of the cover photo
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// The value represents the horizontal manual offset (the amount the user dragged the photo horizontally to show the part of interest) as a percentage of the offset necessary to make the photo fit the space.
        /// </summary>
        [DeserializeAs(Name = "offset_x")]
        public float? OffsetX { get; set; }

        /// <summary>
        /// The value represents the vertical manual offset (the amount the user dragged the photo vertically to show the part of interest) as a percentage of the offset necessary to make the photo fit the space.
        /// </summary>
        [DeserializeAs(Name = "offset_y")]
        public float? OffsetY { get; set; }

        /// <summary>
        /// Direct URL for the person's cover photo image
        /// </summary>
        [DeserializeAs(Name = "source")]
        public string Source { get; set; }
    }
}
