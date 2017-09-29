using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.ApiEngine;

namespace FacebookApi.Interfaces
{
    public interface IPostRequest : IApiRequest
    {
        IApiResponse<TEntity> Execute<TEntity>() where TEntity : class, new();

        Task<IApiResponse<TEntity>> ExecuteAsync<TEntity>() where TEntity : class, new();

        IApiResponse<string> Execute();

        void AddParameter(string name, object value);

        void AddFile(string name, byte[] fileBytes, string contentType);
    }
}
