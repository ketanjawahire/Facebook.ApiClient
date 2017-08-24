using System;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Business Manager
    /// <para>https://developers.facebook.com/docs/marketing-api/businessmanager/</para>
    /// </summary>
    public class Business
    {
        /// <summary>
        /// The Name of the Business
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// ID for the timezone
        /// </summary>
        [DeserializeAs(Name = "timezone_id")]
        public int? TimezoneId { get; set; }

        /// <summary>
        /// The object of the primary page associated with this business manager.
        /// </summary>
        [DeserializeAs(Name = "primary_page")]
        public string PrimaryPage { get; set; }

        /// <summary>
        /// The ID of the business manager
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// The vertical which represents this business manager
        /// </summary>
        [DeserializeAs(Name = "vertical_id")]
        public int VerticalId { get; set; }

        /// <summary>
        /// The last time this business manager was updated
        /// </summary>
        [DeserializeAs(Name = "update_time")]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The last user (name and id) who have updated this business manager
        /// </summary>
        [DeserializeAs(Name = "updated_by")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// The time this brand was created
        /// </summary>
        [DeserializeAs(Name = "creation_time")]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// The user (name and id) who has created this business manager
        /// </summary>
        [DeserializeAs(Name = "created_by")]
        public string CreatedBy { get; set; }
    }
}
