using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Native deeplink data for a link ad.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-link-data-app-link-spec/</para>
    /// </summary>
    public class AdCreativeLinkDataAppLinkSpec
    {
        /// <summary>
        /// Native deeplinks to use on Android
        /// </summary>
        [DeserializeAs(Name = "android")]
        public List<AndroidAppLink> Android { get; set; }

        /// <summary>
        /// Native deeplinks to use on iOS
        /// </summary>
        [DeserializeAs(Name = "ios")]
        public List<IOSAppLink> IOS { get; set; }

        /// <summary>
        /// Native deeplinks to use on iPad
        /// </summary>
        [DeserializeAs(Name = "ipad")]
        public List<IOSAppLink> IPad { get; set; }

        /// <summary>
        /// Native deeplinks to use on iPhone
        /// </summary>
        [DeserializeAs(Name = "iphone")]
        public List<IOSAppLink> IPhone { get; set; }
    }
}
