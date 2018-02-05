using System.Threading.Tasks;

namespace Facebook.ApiClient.Interfaces
{
    /// <summary>
    /// Represents GET API request
    /// </summary>
    public interface IGetRequest : IApiRequest
    {
        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns><see cref="IResponse{TEntity}"/></returns>
        IResponse<TEntity> Execute<TEntity>() where TEntity : class, new();

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns><see cref="IResponse{TEntity}"/></returns>
        Task<IResponse<TEntity>> ExecuteAsync<TEntity>() where TEntity : class, new();

        /// <summary>
        /// Execute current API request.
        /// </summary>
        /// <returns>Returns API response as string</returns>
        IResponse<string> Execute();

        /// <summary>
        /// Add query string parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        void AddQueryParameter(string name, string value);
    }
}