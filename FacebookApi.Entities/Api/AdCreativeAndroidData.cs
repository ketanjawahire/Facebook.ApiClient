using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specification for Android template spec.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-android-data/</para>
    /// </summary>
    public class AdCreativeAndroidData : BaseEntity
    {
        /// <summary>
        /// The name of the Android app, e.g. Electronic Example Android
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        [JsonProperty(PropertyName = "app_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppName { get; set; }

        /// <summary>
        /// A fully qualified package name for intent generation and store linking, e.g. com.electronic
        /// </summary>
        [DeserializeAs(Name = "package")]
        [JsonProperty(PropertyName = "package", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Package { get; set; }

        /// <summary>
        /// A custom URL scheme for the Android App, e.g. example-android://electronic/id={{product.retailor_id | urlencode}}
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Url { get; set; }
    }
}
