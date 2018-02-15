using System.Globalization;
using System.Threading.Tasks;
using Facebook.ApiClient.Enumerations.ApiEngine;
using Facebook.ApiClient.Exceptions;
using Facebook.ApiClient.Interfaces;
using RestSharp;

namespace Facebook.ApiClient.ApiEngine
{
    /// <inheritdoc cref="IPagedRequest" />
    /// <summary>
    /// Represents paged api request
    /// </summary>
    public class PagedRequest  : ApiRequest, IPagedRequest
    {
        /// <inheritdoc />
        /// <summary>
        /// Initialize new instance of <see cref="T:Facebook.ApiClient.ApiEngine.PagedRequest" />
        /// </summary>
        /// <param name="requestUrl">Request Url</param>
        /// <param name="client"><see cref="T:Facebook.ApiClient.ApiEngine.ApiClient" /> used to execute this request</param>
        internal PagedRequest(string requestUrl, ApiClient client) : base(requestUrl, client, ApiRequestHttpMethod.GET)
        {
        }

        /// <inheritdoc />
        public IPagedResponse<TEntity> ExecutePage<TEntity>() where TEntity : class, new()
        {
            StartTimer();
            var response = RestClient.Execute<PagedResponse<TEntity>>(RestRequest);
            StopTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return _processResponse(response);
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public void AddQueryParameter(string name, string value)
        {
            RestRequest.AddQueryParameter(name, value);
        }

        /// <inheritdoc />
        public void AddPageLimit(int limit)
        {
            AddQueryParameter("limit", limit.ToString(CultureInfo.CurrentCulture));
        }
    }
}
