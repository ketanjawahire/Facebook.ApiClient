using FacebookApi.Constants;
using FacebookApi.Enums;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp;
using System.Threading.Tasks;

namespace FacebookApi.ApiEngine
{
    /// <summary>
    /// Represents a Facebook API requests
    /// </summary>
    public class ApiRequest : ApiRequestBase
    {
        /// <summary>
        /// Initialize new instance of <see cref="ApiRequest"/> using given Request Url &amp; <see cref="ApiClient"/>
        /// </summary>
        /// <param name="requestUrl">Request Url</param>
        /// <param name="apiClient"><see cref="ApiClient"/></param>
        public ApiRequest( string requestUrl, ApiClient apiClient)
        {
            _restClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            RequestUri = requestUrl;
            ApiClient = apiClient;
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <param name="method"><see cref="ApiRequestHttpMethod"/></param>
        /// <returns><see cref="IApiResponse{TEntity}"/></returns>
        public IApiResponse<TEntity> Execute<TEntity>(ApiRequestHttpMethod method) where TEntity : class, new()
        {
            var request = _prepareRestRequest(method, RequestUri, RequestParameters);
            var response = _restClient.Execute<TEntity>(request);

            if (response.ErrorException != null)
                throw response.ErrorException;

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <param name="method"><see cref="ApiRequestHttpMethod"/></param>
        /// <returns><see cref="IApiResponse{TEntity}"/></returns>
        public async Task<IApiResponse<TEntity>> ExecuteAsync<TEntity>(ApiRequestHttpMethod method) where TEntity : class, new()
        {
            var request = _prepareRestRequest(method, RequestUri, RequestParameters);
            var response = await _restClient.ExecuteTaskAsync<TEntity>(request);

            if (response.ErrorException != null)
                throw response.ErrorException;

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <param name="method"><see cref="ApiRequestHttpMethod"/></param>
        /// <returns>Returns API response as string</returns>
        public IApiResponse<string> Execute(ApiRequestHttpMethod method)
        {
            var request = _prepareRestRequest(method, RequestUri, RequestParameters);
            var response = _restClient.Execute(request);

            if (response.ErrorException != null)
                throw response.ErrorException;

            return new ApiResponse<string>(response.Content, response.Headers, GetExceptionsFromApiResponse(response));
        }

        //public async Task<IApiResponse<string>> ExecuteAsync(ApiRequestHttpMethod method)
        //{
        //    var request = _prepareRestRequest(method, RequestUri, RequestParameters);
        //    var response = _restClient.ExecuteAsync(request);

        //    if (response.ErrorException != null)
        //        throw response.ErrorException;

        //    return new ApiResponse<string>(response.Content, response.Headers, GetExceptionsFromApiResponse(response));
        //}

    }
}
