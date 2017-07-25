using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    public enum AddAccountDisableReason
    {
        NONE = 0,
        ADS_INTEGRITY_POLICY = 1,
        ADS_IP_REVIEW = 2,
        RISK_PAYMENT = 3,
        GRAY_ACCOUNT_SHUT_DOWN = 4,
        ADS_AFC_REVIEW = 5
    }
}
