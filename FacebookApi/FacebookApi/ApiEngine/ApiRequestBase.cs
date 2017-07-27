using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Enums;
using FacebookApi.Exceptions;
using RestSharp;
using RestSharp.Newtonsoft.Json;
using RestRequest = RestSharp.RestRequest;

namespace FacebookApi.ApiEngine
{
    public class ApiRequestBase
    {
        protected IRestClient _restClient;

        public string RequestUri { get; protected set; }

        public IList<ApiRequestParameter> RequestParameters { get; protected set; }

        public ApiClient ApiClient { get; protected set; }

        protected ApiRequestBase()
        {
            RequestParameters = new List<ApiRequestParameter>();
        }

        private static void _setJsonSerializer(IRestRequest restRequest)
        {
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
        }

        private void _setFBRequestParameters(IRestRequest restRequest)
        {
            restRequest.AddParameter(FacebookApiRequestParameters.API_VERSION, ApiClient.ApiVersion, ParameterType.UrlSegment);
            restRequest.AddParameter(FacebookApiRequestParameters.ACCESS_TOKEN, ApiClient.AccessToken, ParameterType.QueryString);
        }

        private IRestRequest _getRestRequest(ApiRequestHttpMethod requestMethod, string requestUri, IEnumerable<ApiRequestParameter> parameters)
        {
            var request = new RestRequest(requestUri, (Method)requestMethod);

            if (parameters == null) return request;

            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter.Name, parameter.Value, (ParameterType)((int)parameter.Type));
            }

            return request;
        }

        protected IRestRequest _prepareRestRequest(ApiRequestHttpMethod requestMethod, string requestUri,
            IEnumerable<ApiRequestParameter> parameters = null)
        {
            var request = _getRestRequest(requestMethod, requestUri, parameters);

            _setFBRequestParameters(request);
            _setJsonSerializer(request);

            return request;
        }

        public void AddGetOrPostParameter(string parameterName, string parameterValue)
        {
            RequestParameters.Add(new ApiRequestParameter()
            {
                Name = parameterName,
                Type = ApiRequestParameterType.GetOrPost,
                Value = parameterValue
            });
        }

        public void AddUrlSegmentParameter(string parameterName, string parameterValue)
        {
            RequestParameters.Add(new ApiRequestParameter()
            {
                Name = parameterName,
                Type = ApiRequestParameterType.UrlSegment,
                Value = parameterValue
            });
        }

        public void AddHttpHeader(string parameterName, string parameterValue)
        {
            RequestParameters.Add(new ApiRequestParameter()
            {
                Name = parameterName,
                Type = ApiRequestParameterType.HttpHeader,
                Value = parameterValue
            });
        }

        protected static IEnumerable<Exception> GetExceptionsFromApiResponse(IRestResponse apiResponse)
        {
            IList<Exception> exceptions = new List<Exception>();

            if (apiResponse.StatusCode != HttpStatusCode.BadRequest) return exceptions;

            var responseHeaders =
                apiResponse.Headers.ToDictionary(e => e.Name);

            exceptions.Add(new FacebookOAuthException(200, apiResponse.Content)
            {
                FBTraceId =
                    responseHeaders.ContainsKey(FacebookApiResponceHeaders.X_FB_TRACE_ID)
                        ? responseHeaders[FacebookApiResponceHeaders.X_FB_TRACE_ID].Value.ToString()
                        : string.Empty,
                FBRev =
                    responseHeaders.ContainsKey(FacebookApiResponceHeaders.X_FB_REV)
                        ? responseHeaders[FacebookApiResponceHeaders.X_FB_REV].Value.ToString()
                        : string.Empty,
                FBDebug =
                    responseHeaders.ContainsKey(FacebookApiResponceHeaders.X_FB_DEBUG)
                        ? responseHeaders[FacebookApiResponceHeaders.X_FB_DEBUG].Value.ToString()
                        : string.Empty
            });

            return exceptions;
        }
    }
}
