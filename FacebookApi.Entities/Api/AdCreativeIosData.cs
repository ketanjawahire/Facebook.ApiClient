using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specification for iOS template spec.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-ios-data/</para>
    /// </summary>
    public class AdCreativeIosData
    {
        /// <summary>
        /// The name of the iOS app, suitable for display, e.g. Electronic Example iOS
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// The app ID for the App Store, e.g. 1234
        /// </summary>
        [DeserializeAs(Name = "app_store_id")]
        public string AppStoreId { get; set; }

        /// <summary>
        /// A custom scheme for the iOS app, e.g. example-ios://electronic/id={{product.retailor_id | urlencode}}
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string Url { get; set; }
    }
}
