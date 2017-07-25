using FacebookApi.ApiEngine;

namespace FacebookApi.IApiEngine
{
    public interface IPagedResponse<TApiEntity> where TApiEntity : class, new()
    {
        IApiResponse<IPagedResponse<TApiEntity>> GetNextPageData<T>() where T : class, new();

        IApiResponse<IPagedResponse<TApiEntity>> GetPreviousPageData<T>() where T : class, new();
    }
}