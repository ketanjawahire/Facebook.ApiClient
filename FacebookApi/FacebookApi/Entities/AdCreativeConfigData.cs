using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specification for template configs, like app FB ID.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-config-data/</para>
    /// </summary>
    public class AdCreativeConfigData
    {
        /// <summary>
        /// The id of the Facebook App where the deep-link information is stored
        /// </summary>
        [DeserializeAs(Name = "app_id")]
        public string AppId { get; set; }
    }
}
