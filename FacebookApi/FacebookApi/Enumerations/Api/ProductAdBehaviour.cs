using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    /// <summary>
    /// ProductAdBehaviour
    /// </summary>
    public enum ProductAdBehaviour
    {
        /// <summary>
        /// REQUIRE_LAST_SEEN_PRODUCTS
        /// </summary>
        REQUIRE_LAST_SEEN_PRODUCTS,

        /// <summary>
        /// REQUIRE_AVAILABLE_LAST_SEEN_PRODUCTS
        /// </summary>
        REQUIRE_AVAILABLE_LAST_SEEN_PRODUCTS,

        /// <summary>
        /// FALL_BACK_TO_FB_RECOMMENDATIONS
        /// </summary>
        FALL_BACK_TO_FB_RECOMMENDATIONS,


    }
}
