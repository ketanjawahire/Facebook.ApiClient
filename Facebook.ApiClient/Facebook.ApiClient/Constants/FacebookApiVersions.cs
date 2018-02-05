using System.Collections.Generic;

namespace Facebook.ApiClient.Constants
{
    /// <summary>
    /// Represents supported Facebook api version
    /// </summary>
    public static class FacebookApiVersions
    {
        /// <summary>
        /// Default facebook api version : v2.10
        /// </summary>
        public static readonly string DEFAULT = "v2.10";

        /// <summary>
        /// Facebook api version v2.9
        /// </summary>
        public static readonly string V2_10 = "v2.10";

        /// <summary>
        /// Check if given version is a valid FB api version or not
        /// </summary>
        /// <param name="version">API version to check</param>
        /// <returns>True if api version is valid</returns>
        public static bool IsValidVersion(string version)
        {
            var validVersions = new List<string>() {"v2.10"};
            return validVersions.Contains(version);
        }
    }
}
