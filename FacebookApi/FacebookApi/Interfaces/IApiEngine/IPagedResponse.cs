using System.Collections.Generic;
using System.Threading.Tasks;

namespace FacebookApi.Interfaces.IApiEngine
{
    public interface IPagedResponse<TApiEntity> where TApiEntity : class, new()
    {
        IPagedResponse<TApiEntity> GetNextPageData();

        Task<IPagedResponse<TApiEntity>> GetNextPageDataAsync();

        IPagedResponse<TApiEntity> GetPreviousPageData();

        Task<IPagedResponse<TApiEntity>> GetPreviousPageDataAsync();

        IEnumerable<TApiEntity> GetResultData();

        bool IsNextPageDataAvailable();

        bool IsPreviousPageDataAvailable();
    }
}