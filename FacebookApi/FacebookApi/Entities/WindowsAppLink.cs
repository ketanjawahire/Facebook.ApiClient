using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An app link on the Windows or Windows Universal platform.
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/windows-app-link/"/>
    /// </summary>
    public class WindowsAppLink
    {
        /// <summary>
        /// The native apps id in the Windows store.
        /// </summary>
        [DeserializeAs(Name = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// The native apps name in the Windows store.
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DeserializeAs(Name = "package_family_name")]
        public string PackageFamilyName { get; set; }

        /// <summary>
        /// The native Windows URL that will be navigated to.
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string URL { get; set; }
    }
}
