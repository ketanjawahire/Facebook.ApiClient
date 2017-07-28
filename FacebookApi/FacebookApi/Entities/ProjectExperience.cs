using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Information about a project experience
    /// <para>https://developers.facebook.com/docs/graph-api/reference/project-experience/</para>
    /// </summary>
    public class ProjectExperience
    {
        /// <summary>
        /// ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [DeserializeAs(Name = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// From
        /// </summary>
        [DeserializeAs(Name = "from")]
        public User From { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [DeserializeAs(Name = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Tagged users
        /// </summary>
        [DeserializeAs(Name = "with")]
        public IList<User> With { get; set; }
    }
}
