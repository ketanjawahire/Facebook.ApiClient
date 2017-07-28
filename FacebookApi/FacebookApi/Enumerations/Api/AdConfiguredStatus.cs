using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    /// <summary>
    /// The configured status of the ad. The field returns the same value as 'configured_status', and is the suggested one to use.
    /// </summary>
    public enum AdConfiguredStatus
    {
        /// <summary>
        /// ACTIVE
        /// </summary>
        ACTIVE,

        /// <summary>
        /// PAUSED
        /// </summary>
        PAUSED,

        /// <summary>
        /// DELETED
        /// </summary>
        DELETED,

        /// <summary>
        /// ARCHIVED
        /// </summary>
        ARCHIVED
    }
}
