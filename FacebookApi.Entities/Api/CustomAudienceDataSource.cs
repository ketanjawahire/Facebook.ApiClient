using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// JSON dictionary of type, sub_type to indicate by which method the custom audience was created.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/custom-audience-data-source/</para>
    /// </summary>
    public class CustomAudienceDataSource : BaseEntity
    {
        /// <summary>
        /// Additional information on creation source
        /// </summary>
        [DeserializeAs(Name = "creation_params")]
        [JsonProperty(PropertyName = "creation_params", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreationParams { get; set; }

        /// <summary>
        /// Custom Audience type
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }

        /// <summary>
        /// Custom Audience subtype
        /// </summary>
        [DeserializeAs(Name = "sub_type")]
        [JsonProperty(PropertyName = "sub_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SubType { get; set; }


    }
}
