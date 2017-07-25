using System;
using System.Collections.Generic;
using System.Linq;
using FacebookApi.Constants;
using RestSharp;
using FacebookApi.IApiEngine;

namespace FacebookApi.ApiEngine
{
    public class ApiResponse<TEntity> : IApiResponse<TEntity> where TEntity : class 
    {
        public TEntity Result { get; private set; }

        public string ETag { get; private set; }

        public string FBTraceId { get; private set; }

        public string FBApiVersion { get; private set; }

        public string FBDebug { get; private set; }

        public IEnumerable<Exception> Exceptions { get; set; }

        public ApiResponse(TEntity responce, IList<Parameter> headerParameters, IEnumerable<Exception> exceptions)
        {
            Result = responce;
            Exceptions = exceptions;
            SetValuesFromResponceHeaders(headerParameters);
        }

        private void SetValuesFromResponceHeaders(IList<Parameter> headerParameters)
        {
            var tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponceHeaders.X_FB_TRACE_ID));
            if (tempParameter != null)
                FBTraceId = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponceHeaders.FACEBOOK_API_VERSION));
            if (tempParameter != null)
                FBApiVersion = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponceHeaders.X_FB_DEBUG));
            if (tempParameter != null)
                FBDebug = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponceHeaders.ETAG));
            if (tempParameter != null)
                ETag = tempParameter.Value.ToString();
        }
    }
}
