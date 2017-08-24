using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Custom Audience status in code and description format
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/custom-audience-status/</para>
    /// </summary>
    public class CustomAudienceStatus
    {
        /// <summary>
        /// Status code
        /// </summary>
        [DeserializeAs(Name = "code")]
        public long?  Code { get; set; }

        /// <summary>
        /// Status description
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }
    }
}
