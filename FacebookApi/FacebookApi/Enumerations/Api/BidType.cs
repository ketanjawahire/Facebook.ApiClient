using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    /// <summary>
    /// Bid type
    /// </summary>
    public enum BidType
    {
        /// <summary>
        /// Cost per click
        /// </summary>
        CPC,

        /// <summary>
        /// Cost per impression
        /// </summary>
        CPM,

        /// <summary>
        /// MULTI_PREMIUM
        /// </summary>
        MULTI_PREMIUM,

        /// <summary>
        /// ABSOLUTE_OCPM
        /// </summary>
        ABSOLUTE_OCPM,

        /// <summary>
        /// Cost per action
        /// </summary>
        CPA,


    }
}
