using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    /// <summary>
    /// Stored balance status for the ad account
    /// </summary>
    public enum AdAccountStoredBalanceStatus
    {
        /// <summary>
        /// advertisers pay in advance of ad delivery using a stored balance
        /// </summary>
        prepay,

        /// <summary>
        /// advertisers pay after ad delivery and do not use a stored balance
        /// </summary>
        postpay,

        /// <summary>
        ///  account has no payment method added yet
        /// </summary>
        new_user
    }
}
