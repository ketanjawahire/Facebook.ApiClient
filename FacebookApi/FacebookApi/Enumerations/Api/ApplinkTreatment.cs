using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{

    /// <summary>
    /// Deep link fallback behavior for dynamic product ads if the app is not installed.
    /// </summary>
    public enum ApplinkTreatment
    {
        /// <summary>
        /// deeplink_with_web_fallback
        /// </summary>
        deeplink_with_web_fallback,

        /// <summary>
        /// deeplink_with_appstore_fallback
        /// </summary>
        deeplink_with_appstore_fallback,

        /// <summary>
        /// web_only
        /// </summary>
        web_only,


    }
}
