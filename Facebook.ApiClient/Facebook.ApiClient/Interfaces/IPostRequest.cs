using System.Threading.Tasks;

namespace Facebook.ApiClient.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a Facebook API Post requests
    /// </summary>
    public interface IPostRequest : IApiRequest
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
        /// Add Post request parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        void AddParameter(string name, object value);

        /// <summary>
        /// Add file bytes to current POST request
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="fileBytes">File bytes</param>
        /// <param name="contentType">File content</param>
        void AddFile(string name, byte[] fileBytes, string contentType);
    }
}
