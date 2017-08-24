namespace FacebookApi.Entities.Enumerations
{
    /// <summary>
    /// The status set at the ad set level. It can be different from the effective status due to its parent campaign. 
    /// <para>The field returns the same value as 'configured_status', and is the suggested one to use.</para>
    /// </summary>
    public enum AdsetStatus
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
