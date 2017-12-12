using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Native deeplink data for a link ad.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data-app-link-spec/</para>
    /// </summary>
    public class AdCreativeLinkDataAppLinkSpec : BaseEntity
    {
        /// <summary>
        /// Native deeplinks to use on Android
        /// </summary>
        [DeserializeAs(Name = "android")]
        [JsonProperty(PropertyName = "android", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AndroidAppLink> Android { get; set; }

        /// <summary>
        /// Native deeplinks to use on iOS
        /// </summary>
        [DeserializeAs(Name = "ios")]
        [JsonProperty(PropertyName = "ios", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<IOSAppLink> IOS { get; set; }

        /// <summary>
        /// Native deeplinks to use on iPad
        /// </summary>
        [DeserializeAs(Name = "ipad")]
        [JsonProperty(PropertyName = "ipad", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<IOSAppLink> IPad { get; set; }

        /// <summary>
        /// Native deeplinks to use on iPhone
        /// </summary>
        [DeserializeAs(Name = "iphone")]
        [JsonProperty(PropertyName = "iphone", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<IOSAppLink> IPhone { get; set; }
    }
}
