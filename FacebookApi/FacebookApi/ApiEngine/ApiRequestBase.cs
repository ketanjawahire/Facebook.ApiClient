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
        private Stopwatch _apiTimer;
        protected IRestClient RestClient { get; private set; }
        protected IRestRequest RestRequest { get; private set; }

        /// <summary>
        /// <see cref="ApiEngine.ApiClient"/> to use to execute API request
        /// </summary>
        public ApiClient Client { get; protected set; }

        /// <summary>
        /// API request uri
        /// </summary>
        public string RequestUrl { get; protected set; }

        /// <summary>
        /// Initialize instance of <see cref="ApiRequestBase"/>
        /// </summary>
        protected ApiRequestBase(string requestUrl, ApiClient client, ApiRequestHttpMethod method)
        {
            RequestUrl = requestUrl;
            Client = client;

            RestClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);
            RestRequest = new RestRequest(requestUrl, (Method) method);

            SetFBRequestParameters();
        }

        #region Methods to add different request parameters

        public void AddUrlSegment(string name, string value)
        {
            RestRequest.AddUrlSegment(name, value);
        }

        public void AddHttpHeader(string name, string value)
        {
            RestRequest.AddHeader(name, value);
        }

        public void AddCookie(string name, string value)
        {
            RestRequest.AddCookie(name, value);
        }

        #endregion

        private void SetFBRequestParameters()
        {
            RestRequest.AddParameter(FacebookApiRequestParameters.API_VERSION, Client.Version, ParameterType.UrlSegment);
            RestRequest.AddParameter(FacebookApiRequestParameters.ACCESS_TOKEN, Client.AccessToken, ParameterType.QueryString);
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

        /// <summary>
        /// Initialize &amp; start <see cref="_apiTimer"/>
        /// </summary>
        protected void StartTimer()
        {
            if (_apiTimer == null)
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
    }
}
