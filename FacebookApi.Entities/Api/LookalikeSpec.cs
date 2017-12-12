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
    /// Lookalike spec and origin
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/lookalike-spec/</para>
    /// </summary>
    public class LookalikeSpec : BaseEntity
    {
        /// <summary>
        /// Two letter country code. The country to find the lookalikes in.
        /// </summary>
        [DeserializeAs(Name = "country")]
        [JsonProperty(PropertyName = "country", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Country { get; set; }

        /// <summary>
        /// Is this lookalike used in financial service
        /// </summary>
        [DeserializeAs(Name = "is_financial_service")]
        [JsonProperty(PropertyName = "is_financial_service", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsFinancialService { get; set; }

        /// <summary>
        /// The ID of origin Custom Audience. The origin audience you create must have a minimum size of 100.
        /// </summary>
        [DeserializeAs(Name = "origin")]
        [JsonProperty(PropertyName = "origin", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Origin { get; set; }

        /// <summary>
        /// Range 0.01-0.20. Indicates the top x% of original audience in the selected country. The default value is 0.01 which is 1%.s
        /// </summary>
        [DeserializeAs(Name = "ratio")]
        [JsonProperty(PropertyName = "ratio", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float? Ratio { get; set; }

        /// <summary>
        /// Used for tiered lookalikes
        /// </summary>
        [DeserializeAs(Name = "starting_ratio")]
        [JsonProperty(PropertyName = "starting_ratio", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string StartingRatio { get; set; }

        /// <summary>
        /// Two letter country codes. The countries to find the lookalikes in.
        /// </summary>
        [DeserializeAs(Name = "target_countries")]
        [JsonProperty(PropertyName = "target_countries", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> TargetCountries { get; set; }

        /// <summary>
        /// Type of the lookalike audience
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }

    }
}
