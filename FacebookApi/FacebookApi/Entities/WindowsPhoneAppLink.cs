using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An app link on the Windows Phone platform.
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/windows-phone-app-link/"/>
    /// </summary>
    public class WindowsPhoneAppLink
    {
        /// <summary>
        /// The native apps id in the Windows Phone store.
        /// </summary>
        [DeserializeAs(Name = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// The native apps name in the Windows Phone store.
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// The native Windows Phone URL that will be navigated to.
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string URL { get; set; }
    }
}
