using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Enums;
using FacebookApi.Exceptions;
using FacebookApi.IApiEngine;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using RestSharp.Newtonsoft.Json;
using RestRequest = RestSharp.RestRequest;

namespace FacebookApi.ApiEngine
{
    public class ApiClient : IApiClient
    {
        private readonly IRestClient _restClient;
        public string AccessToken { get; private set; }

        public string ApiVersion { get; private set; }

        public string AppId { get; private set; }

        public string AppSecret { get; private set; }

        internal ApiClient(Uri baseUri)
        {
            _restClient = new RestClient(baseUri.GetLeftPart(UriPartial.Path));
        }

        public ApiClient(string accessToken)
        {
            _restClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            _setAccessToken(accessToken);
            _setApiVersion(FacebookApiVersions.DEFAULT);
        }

        public ApiClient(string accessToken, string apiVersion)
        {
            _restClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            _setApiVersion(apiVersion);
            _setAccessToken(accessToken);
        }

        public ApiClient(string appId, string appSecret, string accessToken)
        {
            _restClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            _setApiVersion(FacebookApiVersions.DEFAULT);
            _setAccessToken(accessToken);
            _setAppId(appId, appSecret);
        }

        public ApiClient(string appId, string appSecret, string accessToken, string apiVersion)
        {
            _restClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            _setApiVersion(apiVersion);
            _setAccessToken(accessToken);
            _setAppId(appId, appSecret);
        }

        private void _setApiVersion(string version)
        {
            if (FacebookApiVersions.IsValidVersion(version))
            {
                ApiVersion = version;
            }
            else
            {
                throw new InvalidApiVersionException();
            }
        }

        private void _setAccessToken(string accessToken)
        {
            this.AccessToken = accessToken;
        }

        public void _setAppId(string appId, string appSecret)
        {
            AppId = appId;
            AppSecret = appSecret;
        }

        private static void _setJsonSerializer(IRestRequest restRequest)
        {
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
        }

        private void _setFBRequestParameters(IRestRequest restRequest)
        {
            restRequest.AddParameter(FacebookApiRequestParameters.API_VERSION, ApiVersion, ParameterType.UrlSegment);
            restRequest.AddParameter(FacebookApiRequestParameters.ACCESS_TOKEN, AccessToken, ParameterType.QueryString);
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

        private IRestRequest _prepareRestRequest(ApiRequestHttpMethod requestMethod, string requestUri,
            IEnumerable<ApiRequestParameter> parameters = null)
        {
            var request = _getRestRequest(requestMethod, requestUri, parameters);

            _setFBRequestParameters(request);
            _setJsonSerializer(request);

            return request;
        }

        public IApiResponse<TEntity> Execute<TEntity>(ApiRequestHttpMethod requestMethod, string requestUri,
            IEnumerable<ApiRequestParameter> parameters = null) where TEntity : class, new()
        {
            var request = _prepareRestRequest(requestMethod, requestUri, parameters);
            var response = _restClient.Execute<TEntity>(request);

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));
        }

        public async Task<IApiResponse<TEntity>> ExecuteAsync<TEntity>(ApiRequestHttpMethod requestMethod, string requestUri,
            IEnumerable<ApiRequestParameter> parameters = null) where TEntity : class, new()
        {
            var request = _prepareRestRequest(requestMethod, requestUri, parameters);
            var response = await _restClient.ExecuteTaskAsync<TEntity>(request);

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));
        }

        public IApiResponse<IPagedResponse<TEntity>> ExecutePage<TEntity>(ApiRequestHttpMethod requestMethod, string requestUri,
            IList<ApiRequestParameter> fbApiRequestParameters = null) where TEntity : class, new()
        {
            var request = _prepareRestRequest(requestMethod, requestUri, fbApiRequestParameters);
            var response = _restClient.Execute<PagedResponse<TEntity>>(request);

            return new ApiResponse<IPagedResponse<TEntity>>(response.Data, response.Headers,
                GetExceptionsFromApiResponse(response));
        }

        public async Task<IApiResponse<IPagedResponse<TEntity>>> ExecutePageAsync<TEntity>(ApiRequestHttpMethod requestMethod,
            string requestUri, IList<ApiRequestParameter> fbApiRequestParameters = null) where TEntity : class, new()
        {
            var request = _prepareRestRequest(requestMethod, requestUri, fbApiRequestParameters);
            var response = await _restClient.ExecuteTaskAsync<PagedResponse<TEntity>>(request);

            return new ApiResponse<IPagedResponse<TEntity>>(response.Data, response.Headers,
                GetExceptionsFromApiResponse(response));
        }


        //still half baked
        public IApiResponse<List<BatchResponse>> ExecuteBatch(BatchRequest batchRequest)
        {
            var request = new RestRequest(Method.POST);

            if (batchRequest.BatchParameters.Any())
            {
                foreach (var parameter in batchRequest.BatchParameters)
                {
                    request.AddParameter(parameter.Name, parameter.Value, (ParameterType)((int)parameter.Type));
                }
            }

            var test = batchRequest.Requests.Select(e =>
            {
                dynamic temp = new ExpandoObject();

                if (e.Body != null)
                {
                    if (e.Method == ApiRequestHttpMethod.GET)
                    {
                        e.Url =
                            $"{e.Url}{(e.Url.Contains("?") ? "&" : "?")}{string.Join("&", e.Body.Select(p => $"{p.Name}={HttpUtility.UrlEncode(p.Value)}"))}";
                    }
                    else
                    {
                        temp.body = string.Join("&", e.Body.Select(p => $"{p.Name}={HttpUtility.UrlEncode(p.Value)}"));
                    }
                }

                if (e.DependsOn != null)
                {
                    temp.depend_on = e.DependsOn.Name;
                }

                temp.name = e.Name;
                temp.method = e.Method.ToString();
                temp.relative_url = e.Url;

                return temp;
            });

            request.AddParameter("batch", SimpleJson.SerializeObject(test.ToArray()), ParameterType.GetOrPost);
            request.AddParameter("access_token", AccessToken, ParameterType.QueryString);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            var response = (new RestClient("https://graph.facebook.com/")).Execute<List<BatchResponse>>(request);

            return new ApiResponse<List<BatchResponse>>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));
        }

        private static IEnumerable<Exception> GetExceptionsFromApiResponse(IRestResponse apiResponse)
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
