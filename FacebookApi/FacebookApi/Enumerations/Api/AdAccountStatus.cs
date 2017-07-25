using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    public enum AdAccountStatus
    {
        ACTIVE = 1,
        DISABLED = 2,
        UNSETTLED = 3,
        PENDING_RISK_REVIEW = 7,
        IN_GRACE_PERIOD = 9,
        PENDING_CLOSURE = 100,
        CLOSED = 101,
        PENDING_SETTLEMENT = 102,
        ANY_ACTIVE = 201,
        ANY_CLOSED = 202
    }
}
