using System.Threading.Tasks;

namespace Facebook.ApiClient.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Represents paged api request
    /// </summary>
    public interface IPagedRequest : IApiRequest
    {
        /// <summary>
        /// Execute paged API request
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns>Processed API response of type <see cref="IPagedResponse{TEntity}"/></returns>
        IPagedResponse<TEntity> ExecutePage<TEntity>() where TEntity : class, new();

        /// <summary>
        /// Execute paged API request
        /// </summary>
        /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
        /// <returns>Processed API response of type <see cref="IPagedResponse{TEntity}"/></returns>
        Task<IPagedResponse<TEntity>> ExecutePageAsync<TEntity>() where TEntity : class, new();

        /// <summary>
        /// Add query string parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        void AddQueryParameter(string name, string value);

        /// <summary>
        /// Specify api response page limit
        /// </summary>
        /// <param name="limit">Page limit</param>
        void AddPageLimit(int limit);
    }
}
