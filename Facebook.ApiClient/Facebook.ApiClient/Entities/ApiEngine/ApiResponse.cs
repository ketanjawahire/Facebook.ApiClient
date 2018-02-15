using System;
using System.Collections.Generic;
using System.Linq;
using Facebook.ApiClient.Constants;
using Facebook.ApiClient.Interfaces;
using RestSharp;

namespace Facebook.ApiClient.Entities.ApiEngine
{
    /// <summary>
    /// Represents response received from api
    /// </summary>
    /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
    public class ApiResponse<TEntity> : IResponse<TEntity> where TEntity : class
    {
        /// <summary>
        /// Api result in format of TEntity 
        /// </summary>
        private readonly TEntity _result;

        /// <summary>
        /// List of exceptions from api response
        /// </summary>
        private readonly IEnumerable<Exception> _exceptions;

        /// <summary>
        /// ETag response header value
        /// </summary>
        public string ETag { get; private set; }

        /// <summary>
        /// FBTrace response header value
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Fb")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Fb")]
        public string FbTraceId { get; private set; }

        /// <summary>
        /// FBApiVersion response header value
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Fb")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Fb")]
        public string FbApiVersion { get; private set; }

        /// <summary>
        /// FBDebug response header value
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Fb")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Fb")]
        public string FbDebug { get; private set; }

        /// <summary>
        /// Initialize instance of <see cref="ApiResponse{TEntity}"/>
        /// </summary>
        /// <param name="response">Api Response of type TEntity</param>
        /// <param name="headerParameters">Response headers</param>
        /// <param name="exceptions">API response exceptions</param>
        public ApiResponse(TEntity response, IList<Parameter> headerParameters, IEnumerable<Exception> exceptions)
        {
            _result = response;
            _exceptions = exceptions;
            SetValuesFromResponceHeaders(headerParameters);
        }

        private void SetValuesFromResponceHeaders(IList<Parameter> headerParameters)
        {
            var tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponseHeaders.X_FB_TRACE_ID));
            if (tempParameter != null)
                FbTraceId = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponseHeaders.FACEBOOK_API_VERSION));
            if (tempParameter != null)
                FbApiVersion = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponseHeaders.X_FB_DEBUG));
            if (tempParameter != null)
                FbDebug = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponseHeaders.ETAG));
            if (tempParameter != null)
                ETag = tempParameter.Value.ToString();
        }

        /// <inheritdoc />
        public TEntity GetResult()
        {
            return _result;
        }

        /// <inheritdoc />
        public IEnumerable<Exception> GetExceptions()
        {
            return _exceptions;
        }
    }
}
