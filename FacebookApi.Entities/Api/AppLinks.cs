using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// App Links is an open omni-channel solution for deep linking to content in your mobile app
    /// <para>https://developers.facebook.com/docs/graph-api/reference/app-links/</para>
    /// </summary>
    public class AppLinks : BaseEntity
    {
        /// <summary>
        /// The source url of the app links object
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }

        /// <summary>
        /// App links to Android apps
        /// </summary>
        [DeserializeAs(Name = "android")]
        [JsonProperty(PropertyName = "android", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AndroidAppLink> Android { get; set; }

        /// <summary>
        /// App links to iOS apps
        /// </summary>
        [DeserializeAs(Name = "ios")]
        [JsonProperty(PropertyName = "ios", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<IOSAppLink> IOS { get; set; }

        /// <summary>
        /// App links to iPad apps
        /// </summary>
        [DeserializeAs(Name = "ipad")]
        [JsonProperty(PropertyName = "ipad", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<IOSAppLink> IPad { get; set; }

        /// <summary>
        /// App links to iPhone apps
        /// </summary>
        [DeserializeAs(Name = "iphone")]
        [JsonProperty(PropertyName = "iphone", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<IOSAppLink> IPhone { get; set; }

        /// <summary>
        /// The web equivalent of an app link.An empty value indicates this is a mobile-only object
        /// </summary>
        [DeserializeAs(Name = "web")]
        [JsonProperty(PropertyName = "web", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public WebAppLink Web { get; set; }

        /// <summary>
        /// App links to Windows apps
        /// </summary>
        [DeserializeAs(Name = "windows")]
        [JsonProperty(PropertyName = "windows", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<WindowsAppLink> Windows { get; set; }

        /// <summary>
        /// App links to Windows Phone apps
        /// </summary>
        [DeserializeAs(Name = "windows_phone")]
        [JsonProperty(PropertyName = "windows_phone", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<WindowsPhoneAppLink> WindowsPhone { get; set; }

        /// <summary>
        /// App links to Windows and Windows Phone apps
        /// </summary>
        [DeserializeAs(Name = "windows_universal")]
        [JsonProperty(PropertyName = "windows_universal", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<WindowsAppLink> WindowsUniversal { get; set; }
    }
}
