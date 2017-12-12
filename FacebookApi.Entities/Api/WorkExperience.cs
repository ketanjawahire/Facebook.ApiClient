using System;
using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Information about a user's work
    /// <para>https://developers.facebook.com/docs/graph-api/reference/work-experience/</para>
    /// </summary>
    public class WorkExperience : BaseEntity
    {
        /// <summary>
        /// Description
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// Employer
        /// </summary>
        [DeserializeAs(Name = "employer")]
        [JsonProperty(PropertyName = "employer", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Page Employer { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [DeserializeAs(Name = "end_date")]
        [JsonProperty(PropertyName = "end_date", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Tagged by
        /// </summary>
        [DeserializeAs(Name = "from")]
        [JsonProperty(PropertyName = "from", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public User From { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        [DeserializeAs(Name = "location")]
        [JsonProperty(PropertyName = "location", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Page Location { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        [DeserializeAs(Name = "position")]
        [JsonProperty(PropertyName = "position", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Page Position { get; set; }

        /// <summary>
        /// Projects
        /// </summary>
        [DeserializeAs(Name = "projects")]
        [JsonProperty(PropertyName = "projects", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<ProjectExperience> Projects { get; set; }

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
