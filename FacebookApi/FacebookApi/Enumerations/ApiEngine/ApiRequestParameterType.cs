namespace FacebookApi.Enumerations.ApiEngine
{
    /// <summary>
    /// Type of request parameter
    /// </summary>
    public enum ApiRequestParameterType
    {
        /// <summary>
        /// GetOrPost
        /// </summary>
        GetOrPost = 1,

        /// <summary>
        /// UrlSegment
        /// </summary>
        UrlSegment = 2,

        /// <summary>
        /// HttpHeader
        /// </summary>
        HttpHeader = 3,

        /// <summary>
        /// RequestBody
        /// </summary>
        RequestBody = 4,
    }
}
