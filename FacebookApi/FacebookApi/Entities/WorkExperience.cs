using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Information about a user's work
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/work-experience/"/>
    /// </summary>
    public class WorkExperience
    {
        /// <summary>
        /// Description
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Employer
        /// </summary>
        [DeserializeAs(Name = "employer")]
        public Page Employer { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [DeserializeAs(Name = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Tagged by
        /// </summary>
        [DeserializeAs(Name = "from")]
        public User From { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        [DeserializeAs(Name = "location")]
        public Page Location { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        [DeserializeAs(Name = "position")]
        public Page Position { get; set; }

        /// <summary>
        /// Projects
        /// </summary>
        [DeserializeAs(Name = "projects")]
        public IList<ProjectExperience> Projects { get; set; }

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
