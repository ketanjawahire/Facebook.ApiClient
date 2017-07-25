using System.Collections.Generic;

namespace FacebookApi.Constants
{
    /// <summary>
    /// Represents supported Facebook api version
    /// </summary>
    public static class FacebookApiVersions
    {
        /// <summary>
        /// Default facebook api version : v2.10
        /// </summary>
        public static string DEFAULT = "v2.10";

        /// <summary>
        /// Facebook api version v2.9
        /// </summary>
        public static string V2_9 = "v2.9";

        public static bool IsValidVersion(string version)
        {
            var validVersions = new List<string>() {"v2.8", "v2.9"};
            return validVersions.Contains(version);
        }
    }
}
