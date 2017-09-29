using FacebookApi.Entities.ApiEngine;
using FacebookApi.Enumerations.ApiEngine;
using FacebookApi.Exceptions;
using FacebookApi.Interfaces;
using RestSharp;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using RestRequest = RestSharp.RestRequest;

namespace FacebookApi.ApiEngine
{
    /// <summary>
    /// Represents paged api request
    /// </summary>
    public class PagedRequest  : ApiRequestBase, IPagedRequest
    {
        /// <summary>
        /// Collection of request parameters
        /// </summary>
        public IList<ApiRequestParameter> RequestParameters { get; }

        /// <summary>
        /// Initialize new instance of <see cref="PagedRequest"/>
        /// </summary>
        /// <param name="requestUrl">Request Url</param>
        /// <param name="client"><see cref="ApiClient"/> used to execute this request</param>
        internal PagedRequest(string requestUrl, ApiClient client) : base(requestUrl, client, ApiRequestHttpMethod.GET)
        {
        }

        /// <summary>
        /// Execute paged API request
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns>Processed API response of type <see cref="IPagedResponse{TEntity}"/></returns>
        public IPagedResponse<TEntity> ExecutePage<TEntity>() where TEntity : class, new()
        {
            StartTimer();
            var response = RestClient.Execute<PagedResponse<TEntity>>(RestRequest);
            StopTimer();

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
            StartTimer();
            var response = await RestClient.ExecuteTaskAsync<PagedResponse<TEntity>>(RestRequest);
            StopTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return _processResponse(response);
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
            result.SetApiClient(Client);
            result.SetResponseHeaders(response.Headers);
            result.SetResponseExceptions(GetExceptionsFromResponse(response));
            return result;
        }

        public void AddQueryParameter(string name, string value)
        {
            RestRequest.AddQueryParameter(name, value);
        }

        /// <summary>
        /// Specify api response page limit
        /// </summary>
        /// <param name="limit">Page limit</param>
        public void AddPageLimit(int limit)
        {
            AddQueryParameter("limit", limit.ToString(CultureInfo.CurrentCulture));
        }
    }
}
