using System;
using System.ComponentModel;
using System.Dynamic;
using FacebookApi.Constants;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp;
using System.Threading.Tasks;
using FacebookApi.Entities.ApiEngine;
using FacebookApi.Enumerations.ApiEngine;
using FacebookApi.Exceptions;

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
        /// <param name="client"><see cref="ApiClient"/></param>
        public ApiRequest(string requestUrl, ApiClient client)
        {
            RestClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            RequestUrl = requestUrl;
            Client = client;
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <param name="method"><see cref="ApiRequestHttpMethod"/></param>
        /// <returns><see cref="IApiResponse{TEntity}"/></returns>
        public IApiResponse<TEntity> Execute<TEntity>(ApiRequestHttpMethod method) where TEntity : class, new()
        {
            var request = PrepareRestRequest(method, RequestUrl, RequestParameters);

            StartTimer();
            var response = RestClient.Execute<TEntity>(request);
            StopTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromResponse(response));
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <param name="method"><see cref="ApiRequestHttpMethod"/></param>
        /// <returns><see cref="IApiResponse{TEntity}"/></returns>
        public async Task<IApiResponse<TEntity>> ExecuteAsync<TEntity>(ApiRequestHttpMethod method)
            where TEntity : class, new()
        {
            var request = PrepareRestRequest(method, RequestUrl, RequestParameters);

            StartTimer();
            var response = await RestClient.ExecuteTaskAsync<TEntity>(request);
            StopTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromResponse(response));
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <param name="method"><see cref="ApiRequestHttpMethod"/></param>
        /// <returns>Returns API response as string</returns>
        public IApiResponse<string> Execute(ApiRequestHttpMethod method)
        {
            var request = PrepareRestRequest(method, RequestUrl, RequestParameters);

            StartTimer();
            var response = RestClient.Execute(request);
            StartTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return new ApiResponse<string>(response.Content, response.Headers, GetExceptionsFromResponse(response));
        }
    }
}
