using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// JSON dictionary of type, sub_type to indicate by which method the custom audience was created.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/custom-audience-data-source/</para>
    /// </summary>
    public class CustomAudienceDataSource
    {
        /// <summary>
        /// Additional information on creation source
        /// </summary>
        [DeserializeAs(Name = "creation_params")]
        public string CreationParams { get; set; }

        /// <summary>
        /// Custom Audience type
        /// </summary>
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Custom Audience subtype
        /// </summary>
        [DeserializeAs(Name = "sub_type")]
        public string SubType { get; set; }


    }
}
