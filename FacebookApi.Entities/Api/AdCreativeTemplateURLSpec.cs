using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specifications of template links to create dynamic ad creatives using web, ios, android etc. templates
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-template-url-spec/</para>
    /// </summary>
    public class AdCreativeTemplateURLSpec : BaseEntity
    {
        /// <summary>
        /// AppLink templates for Android
        /// </summary>
        [DeserializeAs(Name = "android")]
        [JsonProperty(PropertyName = "android", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeAndroidData Android { get; set; }

        /// <summary>
        /// Recommended configuration for app-link templates.
        /// </summary>
        [DeserializeAs(Name = "config")]
        [JsonProperty(PropertyName = "config", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeConfigData Config { get; set; }

        /// <summary>
        /// AppLink templates for iOS
        /// </summary>
        [DeserializeAs(Name = "ios")]
        [JsonProperty(PropertyName = "ios", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeIosData iOs { get; set; }

        /// <summary>
        /// AppLink templates for iPad
        /// </summary>
        [DeserializeAs(Name = "ipad")]
        [JsonProperty(PropertyName = "ipad", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeIphoneData iPad { get; set; }

        /// <summary>
        /// AppLink templates for iPhone
        /// </summary>
        [DeserializeAs(Name = "iphone")]
        [JsonProperty(PropertyName = "iphone", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeIpadData iPhone { get; set; }

        /// <summary>
        /// AppLink templates for webs
        /// </summary>
        [DeserializeAs(Name = "web")]
        [JsonProperty(PropertyName = "web", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeWebData Web { get; set; }

        /// <summary>
        /// AppLink templates for windows phone
        /// </summary>
        [DeserializeAs(Name = "windows_phone")]
        [JsonProperty(PropertyName = "windows_phone", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeWindowsPhoneData WindowsPhone { get; set; }
    }
}
