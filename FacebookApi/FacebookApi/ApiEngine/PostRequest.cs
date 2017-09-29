using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Entities.ApiEngine;
using FacebookApi.Enumerations.ApiEngine;
using FacebookApi.Exceptions;
using FacebookApi.Interfaces;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Newtonsoft.Json;
using RestSharp.Serializers;
using RestRequest = RestSharp.RestRequest;

namespace FacebookApi.ApiEngine
{
    /// <summary>
    /// Represents a Facebook API Post requests
    /// </summary>
    public class PostRequest : ApiRequestBase, IPostRequest
    {
        /// <inheritdoc />
        /// <summary>
        /// Initialize new instance of <see cref="T:FacebookApi.ApiEngine.ApiPostRequest" /> using given Request Url &amp; <see cref="T:FacebookApi.ApiEngine.ApiClient" />
        /// </summary>
        /// <param name="requestUrl">Request Url</param>
        /// <param name="client"><see cref="T:FacebookApi.ApiEngine.ApiClient" /></param>
        internal PostRequest(string requestUrl, ApiClient client) : base(requestUrl, client,
            ApiRequestHttpMethod.POST)
        {
        }

        public void AddParameter(string name, object value)
        {
            RestRequest.AddParameter(name, value, ParameterType.GetOrPost);
        }

        public void AddFile(string name, byte[] fileBytes, string contentType)
        {
            RestRequest.AddFile(name, fileBytes, name, contentType);
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
