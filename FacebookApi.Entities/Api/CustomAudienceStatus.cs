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
    /// Custom Audience status in code and description format
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/custom-audience-status/</para>
    /// </summary>
    public class CustomAudienceStatus : BaseEntity
    {
        /// <summary>
        /// Status code
        /// </summary>
        [DeserializeAs(Name = "code")]
        [JsonProperty(PropertyName = "code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Code { get; set; }

        /// <summary>
        /// Status description
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }
    }
}
