namespace FacebookApi.Entities.Enumerations
{
    /// <summary>
    /// The reason why the account was disabled.
    /// </summary>
    public enum AddAccountDisableReason
    {
        /// <summary>
        /// NONE 
        /// </summary>
        NONE = 0,

        /// <summary>
        /// ADS_INTEGRITY_POLICY
        /// </summary>
        ADS_INTEGRITY_POLICY = 1,

        /// <summary>
        /// ADS_IP_REVIEW
        /// </summary>
        ADS_IP_REVIEW = 2,

        /// <summary>
        /// RISK_PAYMEN
        /// </summary>
        RISK_PAYMENT = 3,

        /// <summary>
        /// GRAY_ACCOUNT_SHUT_DOWN
        /// </summary>
        GRAY_ACCOUNT_SHUT_DOWN = 4,

        /// <summary>
        /// ADS_AFC_REVIEW 
        /// </summary>
        ADS_AFC_REVIEW = 5
    }
}
