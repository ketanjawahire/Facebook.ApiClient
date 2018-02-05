using System;
using System.Collections.Generic;

namespace Facebook.ApiClient.Interfaces
{
    /// <summary>
    /// Represents response received from api
    /// </summary>
    /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
    public interface IResponse<out TEntity> where TEntity : class
    {
        /// <summary>
        /// Get Api result data
        /// </summary>
        /// <returns>Api result data</returns>
        TEntity GetResult();

        /// <summary>
        /// Get list of exceptions from API response.
        /// </summary>
        /// <returns>List of exceptions</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        IEnumerable<Exception> GetExceptions();
    }
}