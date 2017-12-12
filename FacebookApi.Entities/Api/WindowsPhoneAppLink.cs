using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An app link on the Windows Phone platform.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/windows-phone-app-link/</para>
    /// </summary>
    public class WindowsPhoneAppLink : BaseEntity
    {
        /// <summary>
        /// The native apps id in the Windows Phone store.
        /// </summary>
        [DeserializeAs(Name = "app_id")]
        [JsonProperty(PropertyName = "app_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppId { get; set; }

        /// <summary>
        /// The native apps name in the Windows Phone store.
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        [JsonProperty(PropertyName = "app_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppName { get; set; }

        /// <summary>
        /// The native Windows Phone URL that will be navigated to.
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string URL { get; set; }
    }
}
