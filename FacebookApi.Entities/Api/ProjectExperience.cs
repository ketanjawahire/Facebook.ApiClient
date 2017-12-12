using System;
using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Information about a project experience
    /// <para>https://developers.facebook.com/docs/graph-api/reference/project-experience/</para>
    /// </summary>
    public class ProjectExperience : BaseEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [DeserializeAs(Name = "end_date")]
        [JsonProperty(PropertyName = "end_date", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// From
        /// </summary>
        [DeserializeAs(Name = "from")]
        [JsonProperty(PropertyName = "from", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public User From { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [DeserializeAs(Name = "start_date")]
        [JsonProperty(PropertyName = "start_date", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Tagged users
        /// </summary>
        [DeserializeAs(Name = "with")]
        [JsonProperty(PropertyName = "with", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<User> With { get; set; }
    }
}
