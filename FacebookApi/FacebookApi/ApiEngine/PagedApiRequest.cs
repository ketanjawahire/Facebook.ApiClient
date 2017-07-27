using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Enums;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp;

namespace FacebookApi.ApiEngine
{
    public class PagedApiRequest : ApiRequestBase
    {
        private string before;
        private string after;
        private string next;
        private string previous;


        public PagedApiRequest(string requestUrl, ApiClient apiClient) : base()
        {
            _restClient = new RestClient(FacebookApiRequestUrls.GRAPH_REQUEST_BASE_URL);

            ApiClient = apiClient;
            RequestUri = requestUrl;
        }

        public void AddPageLimit(int limit)
        {
            AddGetOrPostParameter("limit", limit.ToString());
        }

        private PagedResponse<TEntity> _processResponse<TEntity>(IRestResponse<PagedResponse<TEntity>> response) where TEntity : class, new()
        {
            var result = response.Data;
            result.SetApiClient(ApiClient);
            result.SetResponseHeaders(response.Headers);
            result.SetResponseExceptions(GetExceptionsFromApiResponse(response));

            before = response.Data.Paging.Before;
            after = response.Data.Paging.After;
            next = response.Data.Paging.Next;
            previous = response.Data.Paging.Previous;

            return result;
        }

        public IPagedResponse<TEntity> ExecutePage<TEntity>() where TEntity : class, new()
        {
            var request = _prepareRestRequest(ApiRequestHttpMethod.GET, RequestUri, RequestParameters);
            var response = _restClient.Execute<PagedResponse<TEntity>>(request);

            if (response.ErrorException != null)
                throw response.ErrorException;

            return _processResponse(response);
        }

        public async Task<IPagedResponse<TEntity>> ExecutePageAsync<TEntity>() where TEntity : class, new()
        {
            var request = _prepareRestRequest(ApiRequestHttpMethod.GET, RequestUri, RequestParameters);
            var response = await _restClient.ExecuteTaskAsync<PagedResponse<TEntity>>(request);

            if (response.ErrorException != null)
                throw response.ErrorException;

            return _processResponse(response);
        }
    }
}
