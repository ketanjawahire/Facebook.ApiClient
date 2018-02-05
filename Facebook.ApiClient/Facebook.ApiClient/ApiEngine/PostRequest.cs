using System.Threading.Tasks;
using Facebook.ApiClient.Entities.ApiEngine;
using Facebook.ApiClient.Enumerations.ApiEngine;
using Facebook.ApiClient.Exceptions;
using Facebook.ApiClient.Interfaces;
using RestSharp;

namespace Facebook.ApiClient.ApiEngine
{
    /// <inheritdoc cref="IPostRequest" />
    public class PostRequest : ApiRequest, IPostRequest
    {
        /// <inheritdoc />
        /// <summary>
        /// Initialize new instance of <see cref="PostRequest" /> using given Request Url &amp; <see cref="ApiClient" />
        /// </summary>
        /// <param name="requestUrl">Request Url</param>
        /// <param name="client"><see cref="ApiClient" /></param>
        internal PostRequest(string requestUrl, ApiClient client) : base(requestUrl, client,
            ApiRequestHttpMethod.POST)
        {
        }

        /// <summary>
        /// Add post request parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Paraeter value</param>
        public void AddParameter(string name, object value)
        {
            RestRequest.AddParameter(name, value, ParameterType.GetOrPost);
        }

        /// <inheritdoc />
        public void AddFile(string name, byte[] fileBytes, string contentType)
        {
            RestRequest.AddFile(name, fileBytes, name, contentType);
        }

        /// <inheritdoc />
        public IResponse<TEntity> Execute<TEntity>() where TEntity : class, new()
        {
            StartTimer();
            var response = RestClient.Execute<TEntity>(RestRequest);
            StopTimer();

            if (response.ErrorException != null)
                throw new SDKException(response.Content, response.ErrorException);

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromResponse(response));
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
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
