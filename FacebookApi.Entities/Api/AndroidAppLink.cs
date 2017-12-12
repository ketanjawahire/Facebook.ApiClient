using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An app link on the Android platform.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/android-app-link/</para>
    /// </summary>
    public class AndroidAppLink : BaseEntity
    {
        /// <summary>
        /// The native apps name in the Android store.
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        [JsonProperty(PropertyName = "app_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppName { get; set; }

        /// <summary>
        /// The fully classified class name of the app for intent generation.
        /// </summary>
        [DeserializeAs(Name = "class")]
        [JsonProperty(PropertyName = "class", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Class { get; set; }

        /// <summary>
        /// The fully classified package name of the app for intent generation.
        /// </summary>
        [DeserializeAs(Name = "package")]
        [JsonProperty(PropertyName = "package", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Package { get; set; }

        /// <summary>
        /// The native Android URL that will be navigated to.
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string URL { get; set; }
    }
}
