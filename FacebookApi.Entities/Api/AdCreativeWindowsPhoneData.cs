using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specification for Windows Phone template spec.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-windows-phone-data/</para>
    /// </summary>
    public class AdCreativeWindowsPhoneData
    {
        /// <summary>
        /// The app ID, as a GUID, for app store, e.g. ee728e01-7727-4168-9c8f-85c7eef40112
        /// </summary>
        [DeserializeAs(Name = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the app, suitable for display, e.g. Electronic Example Windows
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// A custom scheme for the Windows Phone App, e.g. example-windows://electronic/id={{product.retailor_id | urlencode}}
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string Url { get; set; }
    }
}
