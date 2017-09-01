﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specification for iPhone template spec.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-iphone-data/</para>
    /// </summary>
    public class AdCreativeIphoneData
    {
        /// <summary>
        /// The name of the app, suitable for display, e.g. Electronic Example iPhone
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// The app ID for the App Store, e.g. 5678
        /// </summary>
        [DeserializeAs(Name = "app_store_id")]
        public string AppStoreId { get; set; }

        /// <summary>
        /// A custom URL scheme for the iPhone app, e.g. example-iphone://electronic/?search={{product.name | urlencode}}
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string Url { get; set; }
    }
}