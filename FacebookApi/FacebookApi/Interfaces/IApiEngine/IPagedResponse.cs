using System.Collections.Generic;
using System.Threading.Tasks;
using FacebookApi.ApiEngine;

namespace FacebookApi.Interfaces.IApiEngine
{
    /// <summary>
    /// Represents paged API response
    /// </summary>
    /// <typeparam name="TApiEntity">Entity class which can be used to represent received API response</typeparam>
    public interface IPagedResponse<TApiEntity> where TApiEntity : class, new()
    {
        /// <summary>
        /// Get next page data from API
        /// </summary>
        /// <returns>Next page data</returns>
        IPagedResponse<TApiEntity> GetNextPageData();

        /// <summary>
        /// Get next page data from API
        /// </summary>
        /// <returns>Next page data</returns>
        Task<IPagedResponse<TApiEntity>> GetNextPageDataAsync();

        /// <summary>
        /// Get previous page data from API
        /// </summary>
        /// <returns>Previous page data</returns>
        IPagedResponse<TApiEntity> GetPreviousPageData();

        /// <summary>
        /// Get previous page data from API
        /// </summary>
        /// <returns>Previous page data</returns>
        Task<IPagedResponse<TApiEntity>> GetPreviousPageDataAsync();

        /// <summary>
        /// Get API response data
        /// </summary>
        /// <returns>API response data</returns>
        IEnumerable<TApiEntity> GetResultData();

        /// <summary>
        /// Check if next page data is available or not
        /// </summary>
        /// <returns>True of <see cref="Paging.Next"/> is not null</returns>
        bool IsNextPageDataAvailable();

        /// <summary>
        /// Check if previous page data is available or not
        /// </summary>
        /// <returns>True of <see cref="Paging.Previous"/> is not null</returns>
        bool IsPreviousPageDataAvailable();
    }
}