namespace FacebookApi.Entities.Enumerations
{
    /// <summary>
    /// Status of the account 
    /// </summary>
    public enum AdAccountStatus
    {
        /// <summary>
        /// ACTIVE
        /// </summary>
        ACTIVE = 1,

        /// <summary>
        /// DISABLED 
        /// </summary>
        DISABLED = 2,

        /// <summary>
        /// UNSETTLED 
        /// </summary>
        UNSETTLED = 3,

        /// <summary>
        /// PENDING_RISK_REVIEW 
        /// </summary>
        PENDING_RISK_REVIEW = 7,

        /// <summary>
        /// IN_GRACE_PERIOD 
        /// </summary>
        IN_GRACE_PERIOD = 9,

        /// <summary>
        /// PENDING_CLOSURE
        /// </summary>
        PENDING_CLOSURE = 100,

        /// <summary>
        /// CLOSED 
        /// </summary>
        CLOSED = 101,

        /// <summary>
        /// PENDING_SETTLEMENT
        /// </summary>
        PENDING_SETTLEMENT = 102,

        /// <summary>
        /// ANY_ACTIVE
        /// </summary>
        ANY_ACTIVE = 201,

        /// <summary>
        /// ANY_CLOSED 
        /// </summary>
        ANY_CLOSED = 202
    }
}
