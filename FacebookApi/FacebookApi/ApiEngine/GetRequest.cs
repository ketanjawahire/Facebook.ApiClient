using FacebookApi.Entities.ApiEngine;
using FacebookApi.Enumerations.ApiEngine;
using FacebookApi.Exceptions;
using FacebookApi.Interfaces;
using System.Threading.Tasks;

namespace FacebookApi.ApiEngine
{
    public class GetRequest : ApiRequestBase, IGetRequest
    {
        internal GetRequest(string requestUrl, ApiClient client) : base(requestUrl, client, ApiRequestHttpMethod.GET)
        {
        }

        public void AddQueryParameter(string name, string value)
        {
            RestRequest.AddQueryParameter(name, value);
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns><see cref="IApiResponse{TEntity}"/></returns>
        public IApiResponse<TEntity> Execute<TEntity>() where TEntity : class, new()
        {
            StartTimer();
            var response = RestClient.Execute<TEntity>(RestRequest);
            StopTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromResponse(response));
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns><see cref="IApiResponse{TEntity}"/></returns>
        public async Task<IApiResponse<TEntity>> ExecuteAsync<TEntity>()
            where TEntity : class, new()
        {
            StartTimer();
            var response = await RestClient.ExecuteTaskAsync<TEntity>(RestRequest);
            StopTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromResponse(response));
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <returns>Returns API response as string</returns>
        public IApiResponse<string> Execute()
        {
            StartTimer();
            var response = RestClient.Execute(RestRequest);
            StartTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return new ApiResponse<string>(response.Content, response.Headers, GetExceptionsFromResponse(response));
        }
    }
}
