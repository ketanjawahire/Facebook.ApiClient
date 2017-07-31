using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Enums;
using FacebookApi.Exceptions;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp;

namespace FacebookApi.ApiEngine
{
    /// <summary>
    /// Represents paged api request
    /// </summary>
    public class PagedApiRequest : ApiRequestBase
    {
        /// <summary>
        /// Initialize new instance of <see cref="PagedApiRequest"/>
        /// </summary>
        /// <param name="requestUrl">Request Url</param>
        /// <param name="apiClient"><see cref="ApiClient"/> used to execute this request</param>
        public PagedApiRequest(string requestUrl, ApiClient apiClient) : base()
        {
            _restClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            ApiClient = apiClient;
            RequestUri = requestUrl;
        }

        /// <summary>
        /// Specify api response page limit
        /// </summary>
        /// <param name="limit">Page limit</param>
        public void AddPageLimit(int limit)
        {
            AddGetOrPostParameter("limit", limit.ToString());
        }

        /// <summary>
        /// Process <see cref="IRestResponse{TEntity}"/>
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <param name="response">Input <see cref="IRestResponse{TEntity}"/></param>
        /// <returns>Processed response of type <see cref="PagedResponse{TApiEntity}"/></returns>
        private PagedResponse<TEntity> _processResponse<TEntity>(IRestResponse<PagedResponse<TEntity>> response) where TEntity : class, new()
        {
            var result = response.Data;
            result.SetApiClient(ApiClient);
            result.SetResponseHeaders(response.Headers);
            result.SetResponseExceptions(GetExceptionsFromApiResponse(response));
            return result;
        }

        /// <summary>
        /// Execute paged API request
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns>Processed API response of type <see cref="IPagedResponse{TEntity}"/></returns>
        public IPagedResponse<TEntity> ExecutePage<TEntity>() where TEntity : class, new()
        {
            var request = _prepareRestRequest(ApiRequestHttpMethod.GET, RequestUri, RequestParameters);

            StartApiTimer();
            var response = _restClient.Execute<PagedResponse<TEntity>>(request);
            StopApiTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return _processResponse(response);
        }

        /// <summary>
        /// Execute paged API request
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns>Processed API response of type <see cref="IPagedResponse{TEntity}"/></returns>
        public async Task<IPagedResponse<TEntity>> ExecutePageAsync<TEntity>() where TEntity : class, new()
        {
            var request = _prepareRestRequest(ApiRequestHttpMethod.GET, RequestUri, RequestParameters);

            StartApiTimer();
            var response = await _restClient.ExecuteTaskAsync<PagedResponse<TEntity>>(request);
            StopApiTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return _processResponse(response);
        }
    }
}
