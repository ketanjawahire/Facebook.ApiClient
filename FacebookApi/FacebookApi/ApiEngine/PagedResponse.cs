using System;
using System.Collections.Generic;
using FacebookApi.Enums;
using FacebookApi.IApiEngine;
using RestSharp.Deserializers;

namespace FacebookApi.ApiEngine
{
    public class PagedResponse<TApiEntity> : IPagedResponse<TApiEntity> where TApiEntity : class, new()
    {
        [DeserializeAs(Name = "data")]
        public List<TApiEntity> Data { get; set; }

        [DeserializeAs(Name = "paging")]
        public Paging Paging { get; set; }


        public IApiResponse<IPagedResponse<TApiEntity>> GetNextPageData<T>() where T : class, new()
        {
            if (string.IsNullOrEmpty(Paging.Next))
            {
                throw new NullReferenceException("Next page link is empty.");
            }

            if (!Uri.TryCreate(Paging.Next, UriKind.Absolute, out Uri nextPageUri))
                throw new UriFormatException("Next page uri is invalid.");

            var test = new ApiClient(nextPageUri);
            return test.ExecutePage<TApiEntity>(ApiRequestHttpMethod.GET, nextPageUri.Query);
        }

        public IApiResponse<IPagedResponse<TApiEntity>> GetPreviousPageData<T>() where T : class, new()
        {
            if (string.IsNullOrEmpty(Paging.Previous))
            {
                throw new NullReferenceException("Previous page link is empty.");
            }

            if (!Uri.TryCreate(Paging.Next, UriKind.Absolute, out Uri previousPageUri))
                throw new UriFormatException("Next page uri is invalid.");

            var test = new ApiClient(previousPageUri);
            return test.ExecutePage<TApiEntity>(ApiRequestHttpMethod.GET, previousPageUri.Query);
        }
    }
}
