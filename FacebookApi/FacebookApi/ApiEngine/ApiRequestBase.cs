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
    /// <summary>
    /// Base class for API request
    /// </summary>
    public class ApiRequestBase
    {
        /// <summary>
        /// Instance of <see cref="RestClient"/> for this request
        /// </summary>
        protected IRestClient _restClient;

        /// <summary>
        /// API request uri
        /// </summary>
        public string RequestUri { get; protected set; }

        /// <summary>
        /// Collection of request parameters
        /// </summary>
        public IList<ApiRequestParameter> RequestParameters { get; protected set; }

        /// <summary>
        /// <see cref="ApiEngine.ApiClient"/> to use to execute API request
        /// </summary>
        public ApiClient ApiClient { get; protected set; }

        /// <summary>
        /// Initialize instance of <see cref="ApiRequestBase"/>
        /// </summary>
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

        /// <summary>
        /// Prepare <see cref="RestRequest"/>
        /// </summary>
        /// <param name="requestMethod">One of <see cref="ApiRequestHttpMethod"/></param>
        /// <param name="requestUri">Request Uri</param>
        /// <param name="parameters">Collection of request parameters</param>
        /// <returns></returns>
        protected IRestRequest _prepareRestRequest(ApiRequestHttpMethod requestMethod, string requestUri,
            IEnumerable<ApiRequestParameter> parameters = null)
        {
            var request = _getRestRequest(requestMethod, requestUri, parameters);

            _setFBRequestParameters(request);
            _setJsonSerializer(request);

            return request;
        }

        /// <summary>
        /// Add request parameter of type <see cref="ApiRequestParameterType.GetOrPost"/>
        /// </summary>
        /// <param name="parameterName">Parameter name</param>
        /// <param name="parameterValue">Parameter value</param>
        public void AddGetOrPostParameter(string parameterName, string parameterValue)
        {
            RequestParameters.Add(new ApiRequestParameter()
            {
                Name = parameterName,
                Type = ApiRequestParameterType.GetOrPost,
                Value = parameterValue
            });
        }

        /// <summary>
        /// Add request parameter of type <see cref="ApiRequestParameterType.UrlSegment"/>
        /// </summary>
        /// <param name="parameterName">Parameter name</param>
        /// <param name="parameterValue">Parameter value</param>
        public void AddUrlSegmentParameter(string parameterName, string parameterValue)
        {
            RequestParameters.Add(new ApiRequestParameter()
            {
                Name = parameterName,
                Type = ApiRequestParameterType.UrlSegment,
                Value = parameterValue
            });
        }

        /// <summary>
        /// Add request parameter of type <see cref="ApiRequestParameterType.HttpHeader"/>
        /// </summary>
        /// <param name="parameterName">Parameter name</param>
        /// <param name="parameterValue">Parameter value</param>
        public void AddHttpHeader(string parameterName, string parameterValue)
        {
            RequestParameters.Add(new ApiRequestParameter()
            {
                Name = parameterName,
                Type = ApiRequestParameterType.HttpHeader,
                Value = parameterValue
            });
        }

        /// <summary>
        /// Check if there is any api exception in received resonse. If yes then return list of api exceptions
        /// </summary>
        /// <param name="apiResponse">Received api response</param>
        /// <returns>List of api exceptions from received response</returns>
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
