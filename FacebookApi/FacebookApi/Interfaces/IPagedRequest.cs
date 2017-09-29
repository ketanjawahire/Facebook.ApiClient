using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Interfaces
{
    public interface IPagedRequest : IApiRequest
    {
        IPagedResponse<TEntity> ExecutePage<TEntity>() where TEntity : class, new();

        Task<IPagedResponse<TEntity>> ExecutePageAsync<TEntity>() where TEntity : class, new();

        void AddQueryParameter(string name, string value);

        void AddPageLimit(int limit);
    }
}
