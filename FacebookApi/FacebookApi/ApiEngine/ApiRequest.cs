using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Enums;
using FacebookApi.Exceptions;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp;
using RestSharp.Newtonsoft.Json;
using RestRequest = RestSharp.RestRequest;

namespace FacebookApi.ApiEngine
{
    public class ApiRequest : ApiRequestBase
    {
        public ApiRequest( string requestUrl, ApiClient apiClient)
        {
            _restClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            RequestUri = requestUrl;
            ApiClient = apiClient;
        }

        public IApiResponse<TEntity> Execute<TEntity>(ApiRequestHttpMethod method) where TEntity : class, new()
        {
            var request = _prepareRestRequest(method, RequestUri, RequestParameters);
            var response = _restClient.Execute<TEntity>(request);

            if (response.ErrorException != null)
                throw response.ErrorException;

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));
        }

        public async Task<IApiResponse<TEntity>> ExecuteAsync<TEntity>(ApiRequestHttpMethod method) where TEntity : class, new()
        {
            var request = _prepareRestRequest(method, RequestUri, RequestParameters);
            var response = await _restClient.ExecuteTaskAsync<TEntity>(request);

            if (response.ErrorException != null)
                throw response.ErrorException;

            return new ApiResponse<TEntity>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));
        }


        //public TEntity Get<TEntity>() where TEntity : class, new()
        //{
        //    var apiResponse = Execute<TEntity>(ApiRequestHttpMethod.GET);
        //    return apiResponse.GetApiResult();
        //}
    }
}
