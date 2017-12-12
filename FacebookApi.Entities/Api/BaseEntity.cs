using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents Base entity for all API entities
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Collection of unparsed json fields from API response
        /// </summary>
        [JsonExtensionData]
#pragma warning disable 649
        private Dictionary<string, JToken> _unparsedValues;
#pragma warning restore 649

        /// <summary>
        /// Initialize new instance of BaseEntity
        /// </summary>
        internal BaseEntity()
        {
        }

        /// <summary>
        /// Convert current entity into JSON string
        /// </summary>
        /// <returns>JSON string</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Gives collection of unparsed json fields from API response
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, JToken> GetUnparsedValues()
        {
            return _unparsedValues;
        }
    }
}
