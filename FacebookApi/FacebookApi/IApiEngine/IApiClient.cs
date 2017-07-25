using System.Collections.Generic;
using System.Threading.Tasks;
using FacebookApi.ApiEngine;
using FacebookApi.Enums;

namespace FacebookApi.IApiEngine
{
    public interface IApiClient
    {
        IApiResponse<TEntity> Execute<TEntity>(ApiRequestHttpMethod requestMethod, string requestUri,
            IEnumerable<ApiRequestParameter> parameters = null) where TEntity : class, new();

        Task<IApiResponse<TEntity>> ExecuteAsync<TEntity>(ApiRequestHttpMethod requestMethod, string requestUri,
            IEnumerable<ApiRequestParameter> parameters = null) where TEntity : class, new();

        IApiResponse<IPagedResponse<TEntity>> ExecutePage<TEntity>(ApiRequestHttpMethod requestMethod, string requestUri,
            IList<ApiRequestParameter> fbApiRequestParameters = null) where TEntity : class, new();

        Task<IApiResponse<IPagedResponse<TEntity>>> ExecutePageAsync<TEntity>(ApiRequestHttpMethod requestMethod,
            string requestUri, IList<ApiRequestParameter> fbApiRequestParameters = null) where TEntity : class, new();
    }
}