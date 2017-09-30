using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Interfaces
{
    /// <summary>
    /// Represents Api request
    /// </summary>
    public interface IApiRequest
    {
        /// <summary>
        /// Get elapsed time during API request
        /// </summary>
        /// <returns></returns>
        TimeSpan GetElapsedTime();

        /// <summary>
        /// Add url segment parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        void AddUrlSegment(string name, string value);

        /// <summary>
        /// Add HTTP request header parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter name</param>
        void AddHttpHeader(string name, string value);

        /// <summary>
        /// Add request cookie parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        void AddCookie(string name, string value);
    }
}
