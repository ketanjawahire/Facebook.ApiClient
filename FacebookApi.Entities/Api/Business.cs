using System;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Business Manager
    /// <para>https://developers.facebook.com/docs/marketing-api/businessmanager/</para>
    /// </summary>
    public class Business : BaseEntity
    {
        /// <summary>
        /// The Name of the Business
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// ID for the timezone
        /// </summary>
        [DeserializeAs(Name = "timezone_id")]
        [JsonProperty(PropertyName = "timezone_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? TimezoneId { get; set; }

        /// <summary>
        /// The object of the primary page associated with this business manager.
        /// </summary>
        [DeserializeAs(Name = "primary_page")]
        [JsonProperty(PropertyName = "primary_page", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PrimaryPage { get; set; }

        /// <summary>
        /// The ID of the business manager
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Id { get; set; }

        /// <summary>
        /// The vertical which represents this business manager
        /// </summary>
        [DeserializeAs(Name = "vertical_id")]
        [JsonProperty(PropertyName = "vertical_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int VerticalId { get; set; }

        /// <summary>
        /// The last time this business manager was updated
        /// </summary>
        [DeserializeAs(Name = "update_time")]
        [JsonProperty(PropertyName = "update_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The last user (name and id) who have updated this business manager
        /// </summary>
        [DeserializeAs(Name = "updated_by")]
        [JsonProperty(PropertyName = "updated_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// The time this brand was created
        /// </summary>
        [DeserializeAs(Name = "creation_time")]
        [JsonProperty(PropertyName = "creation_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// The user (name and id) who has created this business manager
        /// </summary>
        [DeserializeAs(Name = "created_by")]
        [JsonProperty(PropertyName = "created_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreatedBy { get; set; }
    }
}
