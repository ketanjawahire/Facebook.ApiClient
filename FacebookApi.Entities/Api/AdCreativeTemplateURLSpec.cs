using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specifications of template links to create dynamic ad creatives using web, ios, android etc. templates
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-template-url-spec/</para>
    /// </summary>
    public class AdCreativeTemplateURLSpec
    {
        /// <summary>
        /// AppLink templates for Android
        /// </summary>
        [DeserializeAs(Name = "android")]
        public AdCreativeAndroidData Android { get; set; }

        /// <summary>
        /// Recommended configuration for app-link templates.
        /// </summary>
        [DeserializeAs(Name = "config")]
        public AdCreativeConfigData Config { get; set; }

        /// <summary>
        /// AppLink templates for iOS
        /// </summary>
        [DeserializeAs(Name = "ios")]
        public AdCreativeIosData iOs { get; set; }

        /// <summary>
        /// AppLink templates for iPad
        /// </summary>
        [DeserializeAs(Name = "ipad")]
        public AdCreativeIphoneData iPad { get; set; }

        /// <summary>
        /// AppLink templates for iPhone
        /// </summary>
        [DeserializeAs(Name = "iphone")]
        public AdCreativeIpadData iPhone { get; set; }

        /// <summary>
        /// AppLink templates for webs
        /// </summary>
        [DeserializeAs(Name = "web")]
        public AdCreativeWebData Web { get; set; }

        /// <summary>
        /// AppLink templates for windows phone
        /// </summary>
        [DeserializeAs(Name = "windows_phone")]
        public AdCreativeWindowsPhoneData WindowsPhone { get; set; }
    }
}
