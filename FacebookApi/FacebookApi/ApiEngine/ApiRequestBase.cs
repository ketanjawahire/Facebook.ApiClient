using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Entities.ApiEngine;
using FacebookApi.Enumerations.ApiEngine;
using FacebookApi.Exceptions;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Newtonsoft.Json;
using RestSharp.Serializers;
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
        protected IRestClient RestClient { get; set; }

        /// <summary>
        /// Stopwatch timer to measure api call timings
        /// </summary>
        private Stopwatch _apiTimer;

        private ISerializer _jsonSerializer;

        /// <summary>
        /// API request uri
        /// </summary>
        public string RequestUrl { get; protected set; }

        /// <summary>
        /// Collection of request parameters
        /// </summary>
        public IList<ApiRequestParameter> RequestParameters { get; }

        /// <summary>
        /// <see cref="ApiEngine.ApiClient"/> to use to execute API request
        /// </summary>
        public ApiClient Client { get; protected set; }

        /// <summary>
        /// Initialize instance of <see cref="ApiRequestBase"/>
        /// </summary>
        protected ApiRequestBase()
        {
            RequestParameters = new List<ApiRequestParameter>();
        }

        private void _setJsonSerializer(IRestRequest restRequest)
        {
            restRequest.JsonSerializer = _getJsonSerializer();
        }

        private ISerializer _getJsonSerializer()
        {
            return _jsonSerializer ?? new NewtonsoftJsonSerializer();
        }

        /// <summary>
        /// Set JSON serializer of type <see cref="NewtonsoftJsonSerializer"/>
        /// </summary>
        /// <param name="jsonSerializer">Object of type <see cref="NewtonsoftJsonSerializer "/></param>
        internal void SetJsonSerializer(NewtonsoftJsonSerializer jsonSerializer)
        {
            _jsonSerializer = jsonSerializer;
        }

        private void _setFBRequestParameters(IRestRequest restRequest)
        {
            restRequest.AddParameter(FacebookApiRequestParameters.API_VERSION, Client.Version, ParameterType.UrlSegment);
            restRequest.AddParameter(FacebookApiRequestParameters.ACCESS_TOKEN, Client.AccessToken, ParameterType.QueryString);
        }

        private IRestRequest _getRestRequest(ApiRequestHttpMethod requestMethod, Uri requestUri, IEnumerable<ApiRequestParameter> parameters)
        {
            var request = new RestRequest(requestUri, (Method)requestMethod);

            if (parameters == null) return request;

            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter.Name, parameter.Value, (ParameterType)((int)parameter.ParameterType));
            }

            return request;
        }

        private IRestRequest _getRestRequest(ApiRequestHttpMethod requestMethod, string requestUri,
            IEnumerable<ApiRequestParameter> parameters)
        {
            if (Uri.TryCreate(requestUri, UriKind.RelativeOrAbsolute, out Uri parsedUri))
            {
                return _getRestRequest(requestMethod, parsedUri, parameters);
            }

            throw new Exception($"Invalid Uri. {requestUri}");
        }

        /// <summary>
        /// Prepare <see cref="RestRequest"/>
        /// </summary>
        /// <param name="requestMethod">One of <see cref="ApiRequestHttpMethod"/></param>
        /// <param name="requestUri">Request Uri</param>
        /// <param name="parameters">Collection of request parameters</param>
        /// <returns></returns>
        protected IRestRequest PrepareRestRequest(ApiRequestHttpMethod requestMethod, string requestUri,
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
                ParameterType = ApiRequestParameterType.GetOrPost,
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
                ParameterType = ApiRequestParameterType.UrlSegment,
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
                ParameterType = ApiRequestParameterType.HttpHeader,
                Value = parameterValue
            });
        }

        /// <summary>
        /// Initialize &amp; start <see cref="_apiTimer"/>
        /// </summary>
        protected void StartTimer()
        {
            if(_apiTimer == null)
                _apiTimer = new Stopwatch();

            if (_apiTimer.IsRunning)
            {
                _apiTimer.Stop();
                _apiTimer.Reset();
            }

            _apiTimer.Start();
        }

        /// <summary>
        /// Stop <see cref="_apiTimer"/>
        /// </summary>
        protected void StopTimer()
        {
            _apiTimer.Stop();
        }

        /// <summary>
        /// Get elapsed timespan from <see cref="_apiTimer"/>
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetElapsedTime()
        {
            return _apiTimer.Elapsed;
        }

        /// <summary>
        /// Check if there is any api exception in received resonse. If yes then return list of api exceptions
        /// </summary>
        /// <param name="apiResponse">Received api response</param>
        /// <returns>List of api exceptions from received response</returns>
        protected static IEnumerable<FacebookOAuthException> GetExceptionsFromResponse(IRestResponse apiResponse)
        {
            IList<FacebookOAuthException> exceptions = new List<FacebookOAuthException>();

            if (apiResponse.StatusCode != HttpStatusCode.BadRequest) return exceptions;

            var responseHeaders =
                apiResponse.Headers.ToDictionary(e => e.Name);

            var parsedException = JObject.Parse(apiResponse.Content);
            var exceptionCode = parsedException["error"]?["code"] != null
                ? int.Parse(parsedException["error"]["code"].ToString(), CultureInfo.CurrentCulture)
                : 200;


            exceptions.Add(new FacebookOAuthException(exceptionCode, parsedException["error"]?["message"].ToString())
            {
                FBTraceId =
                    responseHeaders.ContainsKey(FacebookApiResponseHeaders.X_FB_TRACE_ID)
                        ? responseHeaders[FacebookApiResponseHeaders.X_FB_TRACE_ID].Value.ToString()
                        : string.Empty,
                FBRev =
                    responseHeaders.ContainsKey(FacebookApiResponseHeaders.X_FB_REV)
                        ? responseHeaders[FacebookApiResponseHeaders.X_FB_REV].Value.ToString()
                        : string.Empty,
                FBDebug =
                    responseHeaders.ContainsKey(FacebookApiResponseHeaders.X_FB_DEBUG)
                        ? responseHeaders[FacebookApiResponseHeaders.X_FB_DEBUG].Value.ToString()
                        : string.Empty,
                RawExceptionString = apiResponse.Content,
                ErrorUserMessage = parsedException["error"]?["error_user_message"]?.ToString(),
                ErrorUserTitle = parsedException["error"]?["error_user_title"]?.ToString(),
                SubCode = parsedException["error"]?["subcode"] != null
                    ? int.Parse(parsedException["error"]["subcode"].ToString())
                    : 0
            });

            return exceptions;
        }
    }
}
