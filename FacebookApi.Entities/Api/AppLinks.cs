using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// App Links is an open omni-channel solution for deep linking to content in your mobile app
    /// <para>https://developers.facebook.com/docs/graph-api/reference/app-links/</para>
    /// </summary>
    public class AppLinks
    {
        /// <summary>
        /// The source url of the app links object
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// App links to Android apps
        /// </summary>
        [DeserializeAs(Name = "android")]
        public List<AndroidAppLink> Android { get; set; }

        /// <summary>
        /// App links to iOS apps
        /// </summary>
        [DeserializeAs(Name = "ios")]
        public List<IOSAppLink> IOS { get; set; }

        /// <summary>
        /// App links to iPad apps
        /// </summary>
        [DeserializeAs(Name = "ipad")]
        public List<IOSAppLink> IPad { get; set; }

        /// <summary>
        /// App links to iPhone apps
        /// </summary>
        [DeserializeAs(Name = "iphone")]
        public List<IOSAppLink> IPhone { get; set; }

        /// <summary>
        /// The web equivalent of an app link.An empty value indicates this is a mobile-only object
        /// </summary>
        [DeserializeAs(Name = "web")]
        public WebAppLink Web { get; set; }

        /// <summary>
        /// App links to Windows apps
        /// </summary>
        [DeserializeAs(Name = "windows")]
        public List<WindowsAppLink> Windows { get; set; }

        /// <summary>
        /// App links to Windows Phone apps
        /// </summary>
        [DeserializeAs(Name = "windows_phone")]
        public List<WindowsPhoneAppLink> WindowsPhone { get; set; }

        /// <summary>
        /// App links to Windows and Windows Phone apps
        /// </summary>
        [DeserializeAs(Name = "windows_universal")]
        public List<WindowsAppLink> WindowsUniversal { get; set; }
    }
}
