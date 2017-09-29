using System.Threading.Tasks;

namespace FacebookApi.Interfaces
{
    public interface IGetRequest : IApiRequest
    {
        IApiResponse<TEntity> Execute<TEntity>() where TEntity : class, new();

        Task<IApiResponse<TEntity>> ExecuteAsync<TEntity>() where TEntity : class, new();

        IApiResponse<string> Execute();

        void AddQueryParameter(string name, string value);
    }
}