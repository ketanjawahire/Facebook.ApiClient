using System.Security.Permissions;

namespace FacebookApi.Interfaces.IApiEngine
{
    public interface IApiResponse<out TEntity> where TEntity : class
    {
        TEntity GetApiResult();
    }
}