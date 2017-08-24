namespace FacebookApi.Entities.Enumerations
{
    /// <summary>
    /// Custom Audience type
    /// </summary>
    public enum CustomAudienceDataSourceType
    {
        /// <summary>
        /// When an audience is created and before uploading any content
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// Created directly from a file
        /// </summary>
        FILE_IMPORTED,

        /// <summary>
        /// Created from some website event
        /// </summary>
        EVENT_BASED,

        /// <summary>
        /// Lookalike audience
        /// </summary>
        SEED_BASED,

        /// <summary>
        /// Created using third-party data
        /// </summary>
        THIRD_PARTY_IMPORTED,

        /// <summary>
        /// Values pasted into the input field manually via Facebook interfaces
        /// </summary>
        COPY_PASTE,

        /// <summary>
        /// Created via an importer
        /// </summary>
        CONTACT_IMPORTER,

        /// <summary>
        /// HOUSEHOLD_AUDIENCE
        /// </summary>
        HOUSEHOLD_AUDIENCE,


    }
}
