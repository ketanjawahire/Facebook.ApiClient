using System.Threading.Tasks;
using Facebook.ApiClient.Entities.ApiEngine;
using Facebook.ApiClient.Enumerations.ApiEngine;
using Facebook.ApiClient.Exceptions;
using Facebook.ApiClient.Interfaces;
using Newtonsoft.Json.Linq;

namespace Facebook.ApiClient.ApiEngine
{
    /// <inheritdoc cref="IGetRequest" />
    public class GetRequest : ApiRequest, IGetRequest
    {
        internal GetRequest(string requestUrl, ApiClient client) : base(requestUrl, client, ApiRequestHttpMethod.GET)
        {
        }

        /// <inheritdoc />
        public void AddQueryParameter(string name, string value)
        {
            RestRequest.AddQueryParameter(name, value);
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns><see cref="IResponse{TEntity}"/></returns>
        public IResponse<TEntity> Execute<TEntity>() where TEntity : class, new()
        {
            var jsonSerializer = GetJsonSerializer();

            StartTimer();

            var response = RestClient.Execute(RestRequest);
            var result = jsonSerializer.Deserialize<TEntity>(new JTokenReader(JToken.Parse(response.Content)));

            StopTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            //return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromResponse(response));
            return new ApiResponse<TEntity>(result, response.Headers, GetExceptionsFromResponse(response));
        }

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns><see cref="IResponse{TEntity}"/></returns>
        public async Task<IResponse<TEntity>> ExecuteAsync<TEntity>()
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
        public IResponse<string> Execute()
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
