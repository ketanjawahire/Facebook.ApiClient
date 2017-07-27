using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Enums;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp;
using RestSharp.Deserializers;

namespace FacebookApi.ApiEngine
{
    public class PagedResponse<TApiEntity> : IPagedResponse<TApiEntity> where TApiEntity : class, new()
    {
        public ApiClient ApiClient { get; private set; }

        [DeserializeAs(Name = "data")]
        public List<TApiEntity> Data { get; set; }

        [DeserializeAs(Name = "paging")]
        public Paging Paging { get; set; }

        public string ETag { get; private set; }

        public string FBTraceId { get; private set; }

        public string FBApiVersion { get; private set; }

        public string FBDebug { get; private set; }

        public IEnumerable<Exception> Exceptions { get; set; }

        public PagedResponse()
        {
        }

        public void SetResponseHeaders(IEnumerable<Parameter> headers)
        {
            
        }

        public void SetResponseExceptions(IEnumerable<Exception> exceptions)
        {

        }

        public void SetApiClient(ApiClient apiClient)
        {
            this.ApiClient = apiClient;
        }

        private PagedApiRequest _getNextPageRequest()
        {
            if (string.IsNullOrEmpty(Paging.Next))
            {
                throw new NullReferenceException("Next page link is empty.");
            }

            if (!Uri.TryCreate(Paging.Next, UriKind.Absolute, out Uri nextPageUri))
                throw new UriFormatException("Next page uri is invalid.");

            //stupid logic :(
            var url = $"{string.Join(string.Empty, nextPageUri.Segments.Skip(2))}{nextPageUri.Query}";

            var nextPageRequest = new PagedApiRequest(url, ApiClient);

            return nextPageRequest;
        }

        private PagedApiRequest _getPreviousPageRequest()
        {
            if (string.IsNullOrEmpty(Paging.Previous))
            {
                throw new NullReferenceException("Previous page link is empty.");
            }

            if (!Uri.TryCreate(Paging.Previous, UriKind.Absolute, out Uri previousPageUri))
                throw new UriFormatException("Previous page uri is invalid.");

            //stupid logic :(
            var url = $"{previousPageUri.Segments.Skip(0).Skip(1)}{previousPageUri.Query}";

            var previousPageRequest = new PagedApiRequest(url, ApiClient);
            return previousPageRequest;
        }

        public IPagedResponse<TApiEntity> GetNextPageData()
        {
            var nextPageRequest = _getNextPageRequest();
            return nextPageRequest.ExecutePage<TApiEntity>();
        }

        public async Task<IPagedResponse<TApiEntity>> GetNextPageDataAsync()
        {
            var nextPageRequest = _getNextPageRequest();
            return await nextPageRequest.ExecutePageAsync<TApiEntity>();
        }

        public IPagedResponse<TApiEntity> GetPreviousPageData()
        {
            var previousPageRequest = _getPreviousPageRequest();
            return previousPageRequest.ExecutePage<TApiEntity>();
        }

        public async Task<IPagedResponse<TApiEntity>> GetPreviousPageDataAsync()
        {
            var previousPageRequest = _getPreviousPageRequest();
            return await previousPageRequest.ExecutePageAsync<TApiEntity>();
        }

        public IEnumerable<TApiEntity> GetResultData()
        {
            return this.Data;
        }

        public bool IsNextPageDataAvailable()
        {
            return !string.IsNullOrEmpty(Paging?.Next);
        }

        public bool IsPreviousPageDataAvailable()
        {
            return !string.IsNullOrEmpty(Paging?.Previous);
        }

        private void SetValuesFromResponceHeaders(IList<Parameter> headerParameters)
        {
            var tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponceHeaders.X_FB_TRACE_ID));
            if (tempParameter != null)
                FBTraceId = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponceHeaders.FACEBOOK_API_VERSION));
            if (tempParameter != null)
                FBApiVersion = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponceHeaders.X_FB_DEBUG));
            if (tempParameter != null)
                FBDebug = tempParameter.Value.ToString();

            tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(FacebookApiResponceHeaders.ETAG));
            if (tempParameter != null)
                ETag = tempParameter.Value.ToString();
        }
    }
}
