using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An app link on the iOS platform.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/ios-app-link/</para>
    /// </summary>
    public class IOSAppLink
    {
        /// <summary>
        /// The native apps name in the iTunes store.
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// The native apps ID in the iTunes store.
        /// </summary>
        [DeserializeAs(Name = "app_store_id")]
        public string AppStoreId { get; set; }

        /// <summary>
        /// The native iOS URL that will be navigated to.
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string URL { get; set; }
    }
}
