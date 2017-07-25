using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An app link on the Android platform.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/android-app-link/</para>
    /// </summary>
    public class AndroidAppLink
    {
        /// <summary>
        /// The native apps name in the Android store.
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// The fully classified class name of the app for intent generation.
        /// </summary>
        [DeserializeAs(Name = "class")]
        public string Class { get; set; }

        /// <summary>
        /// The fully classified package name of the app for intent generation.
        /// </summary>
        [DeserializeAs(Name = "package")]
        public string Package { get; set; }

        /// <summary>
        /// The native Android URL that will be navigated to.
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string URL { get; set; }
    }
}
