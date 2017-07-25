using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    public enum ProductAdBehaviour
    {
        REQUIRE_LAST_SEEN_PRODUCTS,
        REQUIRE_AVAILABLE_LAST_SEEN_PRODUCTS,
        FALL_BACK_TO_FB_RECOMMENDATIONS
    }
}
