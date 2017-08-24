namespace FacebookApi.Entities.Enumerations
{
    /// <summary>
    /// The status set at the ad set level. It can be different from the effective status due to its parent campaign. Prefer using 'status' instead of this.
    /// </summary>
    public enum AdsetConfiguredStatus
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
        ARCHIVED,


    }
}
